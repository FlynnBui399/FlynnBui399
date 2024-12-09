#%%
import dis
from turtle import back
import pygame
import sys
import numpy as np
import time
import math
from sklearn import base
from sympy import false, true
import os
from gmkanimation import *
pygame.init()
# Constants
WIDTH, HEIGHT = 700, 700
BOARD_SIZE = 15
CELL_SIZE = WIDTH // BOARD_SIZE
BLACK = (0, 0, 0)
BROWN = (130, 91, 50)
#GMK Implementation
class GomokuAI:
    def __init__(self, depth=3):
        self.depth = depth
        self.board = np.zeros((BOARD_SIZE, BOARD_SIZE), dtype=int)
        self.current_i = -1
        self.current_j = -1
        self.next_bound = {}
        self.board_value = 0
        self.turn = 0
        self.last_played = 0
        self.empty_cells = BOARD_SIZE * BOARD_SIZE
        self.pattern_dict = self.create_pattern_dict()
        self.cache = {}  # Add cache
        
    def find_winning_moves(self):
        winning_moves = []
        for i in range(BOARD_SIZE):
            for j in range(BOARD_SIZE):
                if self.board[i][j] == 0:
                    if self.isWon(i, j, 1):
                        winning_moves.append((i, j))
        return winning_moves
    
    def isWon(self, i, j, player):
        directions = [(-1, 0), (1, 0), (0, -1), (0, 1), (-1, 1), (1, -1), (-1, -1), (1, 1)]
        for dir in directions:
            if self.count_consecutive(i, j, dir, player) == 4: 
                return True
        return False


    def find_blocking_moves(self):
        blocking_moves = []
        for i in range(BOARD_SIZE):
            for j in range(BOARD_SIZE):
                if self.board[i][j] == 0:
                    if self.is_blocking_move(i, j):
                        blocking_moves.append((i, j))
        return blocking_moves
    
    def is_blocking_move(self, i, j):
        directions = [(-1, 0), (1, 0), (0, -1), (0, 1), (-1, 1), (1, -1), (-1, -1), (1, 1)]
        for dir in directions:
            consecutive_count = self.count_consecutive(i, j, dir, -1)
            if consecutive_count >= 4:
                return True
            elif consecutive_count == 3:
                if self.is_opened_streak(i, j, dir, -1):
                    return True
                
        return False
    
    def is_opened_streak(self, i, j, direction, player):
        di, dj = direction
        x1, y1 = i + di, j + dj 
        x2, y2 = i - di, j - dj
        if 0 <= x1 < BOARD_SIZE and 0 <= y1 < BOARD_SIZE and self.board[x1][y1] == 0:
            x1_2, y1_2 = x1 + di, y1 + dj
            if 0 <= x1_2 < BOARD_SIZE and 0 <= y1_2 < BOARD_SIZE and self.board[x1_2][y1_2] == 0:
                return True
   
        if 0 <= x2 < BOARD_SIZE and 0 <= y2 < BOARD_SIZE and self.board[x2][y2] == 0:
            x2_2, y2_2 = x2 - di, y2 - dj
            if 0 <= x2_2 < BOARD_SIZE and 0 <= y2_2 < BOARD_SIZE and self.board[x2_2][y2_2] == 0:
                return True
        return False
    def count_consecutive(self, i, j, direction, player): # Count streak of component in multi direction
        count = 0
        di, dj = direction
        for step in range(1, 10): 
            ni, nj = i + di * step, j + dj * step
            if 0 <= ni < BOARD_SIZE and 0 <= nj < BOARD_SIZE and self.board[ni][nj] == player:
                count += 1
            else:
                break
        return count

    def minimax(self, depth, is_maximizing, alpha, beta):
        board_hash = hash(self.board.tobytes())
        if board_hash in self.cache:
            return self.cache[board_hash]

        if depth == 0 or self.is_game_over():
            score = self.evaluate_board()
            self.cache[board_hash] = score
            return score

        if is_maximizing:
            max_eval = -math.inf
            for i, j in self.child_nodes(self.next_bound):
                self.set_state(i, j, 1)
                self.update_bound(i, j, self.next_bound)
                eval = self.minimax(depth - 1, False, alpha, beta)
                self.set_state(i, j, 0)
                max_eval = max(max_eval, eval)
                alpha = max(alpha, eval)
                if beta <= alpha:
                    break
            self.cache[board_hash] = max_eval
            return max_eval
        else:
            min_eval = math.inf
            for i, j in self.child_nodes(self.next_bound):
                self.set_state(i, j, -1)
                self.update_bound(i, j, self.next_bound)
                eval = self.minimax(depth - 1, True, alpha, beta)
                self.set_state(i, j, 0)
                min_eval = min(min_eval, eval)
                beta = min(beta, eval)
                if beta <= alpha:
                    break
            self.cache[board_hash] = min_eval
            return min_eval

    def is_game_over(self):
        for i in range(BOARD_SIZE):
            for j in range(BOARD_SIZE):
                if self.board[i][j] != 0 and self.is_five(i, j, self.board[i][j]):
                    return True
        return self.empty_cells == 0
    
    def evaluate_board(self):
        score = 0
        directions = [(-1, 0), (1, 0), (0, -1), (0, 1), (-1, 1), (1, -1), (-1, -1), (1, 1)]
        for i in range(max(0, self.current_i - 2), min(BOARD_SIZE, self.current_i + 3)):
            for j in range(max(0, self.current_j - 2), min(BOARD_SIZE, self.current_j + 3)):
                if self.board[i][j] != 0:
                    for dir in directions:
                        score += self.count_pattern(i, j, dir, self.board[i][j], {}, True)
        center = BOARD_SIZE // 2
        score += (center - abs(self.current_i - center)) + (center - abs(self.current_j - center))
        return score

    def create_pattern_dict(self):
        return {
            (1, 1, 1, 1, 1): 100000,
            (0, 1, 1, 1, 1, 0): 10000,
            (0, 1, 1, 1, 0): 1000,
            (0, 1, 1, 0): 100,
            (0, 1, 0): 10
        }

    def is_valid(self, i, j, state=True):
        if i < 0 or i >= BOARD_SIZE or j < 0 or j >= BOARD_SIZE:
            return False
        if state:
            return self.board[i][j] == 0
        return True

    def set_state(self, i, j, state):
        if self.is_valid(i, j):
            if self.board[i][j] == 0 and state != 0:
                self.empty_cells -= 1
            elif self.board[i][j] != 0 and state == 0:
                self.empty_cells += 1
            self.board[i][j] = state
            self.last_played = state
        else:
            print(f"Invalid move: ({i}, {j})")

    def count_direction(self, i, j, xdir, ydir, state):
        count = 0
        for step in range(1, 5):
            if xdir != 0 and (j + xdir*step < 0 or j + xdir*step >= BOARD_SIZE):
                break
            if ydir != 0 and (i + ydir*step < 0 or i + ydir*step >= BOARD_SIZE):
                break
            if self.board[i + ydir*step][j + xdir*step] == state:
                count += 1
            else:
                break
        return count

    def is_five(self, i, j, state):
        directions = [
            [(-1, 0), (1, 0)],
            [(0, -1), (0, 1)],
            [(-1, 1), (1, -1)],
            [(-1, -1), (1, 1)]
        ]
        for dir in directions:
            count = 1
            for d in dir:
                step = 1
                while True:
                    next_i = i + d[0] * step
                    next_j = j + d[1] * step
                    if next_i < 0 or next_i >= BOARD_SIZE or next_j < 0 or next_j >= BOARD_SIZE or self.board[next_i][next_j] != state:
                        break
                    count += 1
                    step += 1
            if count == 5:
                return True
        return False
            
    def child_nodes(self, bound):
        for pos in sorted(bound.items(), key=lambda el: el[1], reverse=True):
            yield pos[0]

    def update_bound(self, new_i, new_j, bound):
        played = (new_i, new_j)
        if played in bound:
            bound.pop(played)
        directions = [(-1, 0), (1, 0), (0, -1), (0, 1), (-1, 1), (1, -1), (-1, -1), (1, 1)]
        for dir in directions:
            new_col = new_j + dir[0]
            new_row = new_i + dir[1]
            if self.is_valid(new_row, new_col) and (new_row, new_col) not in bound:
                bound[(new_row, new_col)] = 0
        return bound
    def count_pattern(self, i_0, j_0, pattern, score, bound, flag):
        directions = [(1, 0), (1, 1), (0, 1), (-1, 1)]
        length = len(pattern)
        count = 0

        for dir in directions:
            if dir[0] * dir[1] == 0:
                steps_back = dir[0] * min(5, j_0) + dir[1] * min(5, i_0)
            elif dir[0] == 1:
                steps_back = min(5, j_0, i_0)
            else:
                steps_back = min(5, BOARD_SIZE-1-j_0, i_0)
            i_start = i_0 - steps_back * dir[1]
            j_start = j_0 - steps_back * dir[0]

            z = 0
            while z <= steps_back:
                i_new = i_start + z*dir[1]
                j_new = j_start + z*dir[0]
                index = 0
                remember = []
                while index < length and self.is_valid(i_new, j_new, state=False) and self.board[i_new][j_new] == pattern[index]:
                    if self.is_valid(i_new, j_new):
                        remember.append((i_new, j_new))
                    i_new = i_new + dir[1]
                    j_new = j_new + dir[0]
                    index += 1

                if index == length:
                    count += 1
                    for pos in remember:
                        if pos not in bound:
                            bound[pos] = 0
                        bound[pos] += flag*score
                    z += index
                else:
                    z += 1

        return count

    def evaluate(self, new_i, new_j, board_value, turn, bound):
        value_before = 0
        value_after = 0
    
        for pattern in self.pattern_dict:
            score = self.pattern_dict[pattern]
            value_before += self.count_pattern(new_i, new_j, pattern, abs(score), bound, -1)*score
            self.board[new_i][new_j] = turn
            value_after += self.count_pattern(new_i, new_j, pattern, abs(score), bound, 1) *score
            self.board[new_i][new_j] = 0
        
        return board_value + value_after - value_before

    def alpha_beta_pruning(self, depth, board_value, bound, alpha, beta, maximizing_player):
        if depth <= 0 or self.is_five(self.current_i, self.current_j, self.last_played):
            return board_value

        if maximizing_player:
            max_val = float('-inf')
            for child in self.child_nodes(bound):
                i, j = child[0], child[1]
                new_bound = dict(bound)
                new_val = self.evaluate(i, j, board_value, 1, new_bound)
                self.board[i][j] = 1
                self.update_bound(i, j, new_bound)
                eval = self.alpha_beta_pruning(depth-1, new_val, new_bound, alpha, beta, False)
                if eval > max_val:
                    max_val = eval
                    if depth == self.depth:
                        self.current_i = i
                        self.current_j = j
                        self.board_value = eval
                        self.next_bound = new_bound
                alpha = max(alpha, eval)
                self.board[i][j] = 0
                del new_bound
                if beta <= alpha:
                    break
            return max_val
        else:
            min_val = float('inf')
            for child in self.child_nodes(bound):
                i, j = child[0], child[1]
                new_bound = dict(bound)
                new_val = self.evaluate(i, j, board_value, -1, new_bound)
                self.board[i][j] = -1
                self.update_bound(i, j, new_bound)
                eval = self.alpha_beta_pruning(depth-1, new_val, new_bound, alpha, beta, True)
                if eval < min_val:
                    min_val = eval
                    if depth == self.depth:
                        self.current_i = i
                        self.current_j = j
                        self.board_value = eval
                        self.next_bound = new_bound
                beta = min(beta, eval)
                self.board[i][j] = 0
                del new_bound
                if beta <= alpha:
                    break
            return min_val

    def first_move(self):
        self.current_i, self.current_j = 7, 7
        self.set_state(self.current_i, self.current_j, 1)

def ai_move(ai):
    start_time = time.time()
    winning_moves=ai.find_winning_moves()
    if winning_moves:
        ai.current_i, ai.current_j = winning_moves[0]
    else:
        blocking_moves = ai.find_blocking_moves()
        if blocking_moves:
            ai.current_i, ai.current_j = blocking_moves[0]
            print(f'AI blocking player move at: ({ai.current_i}, {ai.current_j})')
        else:
            ai.alpha_beta_pruning(ai.depth, ai.board_value, ai.next_bound, float('-inf'), float('inf'), True)
    end_time = time.time()
    print('Finished alpha-beta pruning in:', end_time - start_time)

    if ai.is_valid(ai.current_i, ai.current_j):
        print(ai.current_i, ai.current_j)
        ai.set_state(ai.current_i, ai.current_j, 1)  # Always set AI move to 1 (black)
        ai.update_bound(ai.current_i, ai.current_j, ai.next_bound)
    else:
        print(f'Error: i and j not valid. Given: {ai.current_i}, {ai.current_j}')
        bound_sorted = sorted(ai.next_bound.items(), key=lambda el: el[1], reverse=True)
        pos = bound_sorted[0][0]
        ai.current_i, ai.current_j = pos[0], pos[1]
        ai.set_state(ai.current_i, ai.current_j, 1)  # Always set AI move to 1 (black)
        ai.update_bound(ai.current_i, ai.current_j, ai.next_bound)
        print(f'AI move at: ({ai.current_i}, {ai.current_j})')
    
    return ai.current_i, ai.current_j

def check_human_move(ai, mouse_pos, player):
    move_i = mouse_pos[1] // CELL_SIZE
    move_j = mouse_pos[0] // CELL_SIZE
    
    if ai.is_valid(move_i, move_j):
        ai.board_value = ai.evaluate(move_i, move_j, ai.board_value, player, ai.next_bound)
        ai.set_state(move_i, move_j, player)
        ai.update_bound(move_i, move_j, ai.next_bound)
        return move_i, move_j
    return None

def draw_board(ai):
    screen.fill(BROWN)
    for i in range(BOARD_SIZE):
        pygame.draw.line(screen, BLACK, (i * CELL_SIZE, 0), (i * CELL_SIZE, HEIGHT), 1)
        pygame.draw.line(screen, BLACK, (0, i * CELL_SIZE), (WIDTH, i * CELL_SIZE), 1)
    
    for row in range(BOARD_SIZE):
        for col in range(BOARD_SIZE):
            if ai.board[row][col] == 1:
                pygame.draw.circle(screen, BLACK, (col * CELL_SIZE + CELL_SIZE // 2, row * CELL_SIZE + CELL_SIZE // 2), CELL_SIZE // 2 - 2)
            elif ai.board[row][col] == -1:
                pygame.draw.circle(screen, WHITE, (col * CELL_SIZE + CELL_SIZE // 2, row * CELL_SIZE + CELL_SIZE // 2), CELL_SIZE // 2 - 2)

def main():
    ai = GomokuAI()
    game_mode = None
    game_over = False
    current_player = 1  # 1 for black (AI), -1 for white (human)  
    while not game_over:
        if game_mode is None:
            draw_menu()
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    pygame.quit()
                    sys.exit()
                elif event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_1:
                        game_mode = "AI"
                        ai.first_move()
                        current_player = -1  # Human plays first after AI's first move
                    elif event.key == pygame.K_2:
                        game_mode = "2P"
                    elif event.key == pygame.K_ESCAPE:
                        pygame.quit()
                        sys.exit()
        else:
            draw_board(ai)
            pygame.display.flip()
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                    pygame.quit()
                    sys.exit()
                elif event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_ESCAPE:
                        pygame.quit()
                        sys.exit()
                    elif event.key == pygame.K_r and game_over:
                        # Reset the game and return to menu
                        ai = GomokuAI()
                        game_mode = None
                        game_over = False
                        current_player = 1
                        break
                elif event.type == pygame.MOUSEBUTTONDOWN and not game_over:
                    if (game_mode == "AI" and current_player == -1) or game_mode == "2P":
                        mouse_pos = pygame.mouse.get_pos()
                        move = check_human_move(ai, mouse_pos, current_player)
                        if move:
                            if ai.is_five(move[0], move[1], current_player):
                                game_over = True
                                draw_board(ai)
                                pygame.display.flip()
                            elif game_mode == "AI":
                                current_player = 1  # Switch to AI's turn
                            else:
                                current_player *= -1  # Switch players in 2P mode
               
            if game_mode == "AI" and current_player == 1 and not game_over:
                move = ai_move(ai)
                if move is not None:
                    if ai.is_five(move[0], move[1], 1):
                        game_over = True
                        draw_board(ai)
                        pygame.display.flip()
                    else:
                        current_player = -1  # Switch back to human's turn
                else:
                    game_over = True  # If AI can't move, end the game
            if ai.empty_cells == 0:
                game_over = True
            pygame.display.flip()
            check_over(game_over,current_player) 
        while game_over:
            for event in pygame.event.get():     
                if event.type == pygame.QUIT:
                    pygame.quit()
                    sys.exit()
                elif event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_ESCAPE:
                        pygame.quit()
                        sys.exit()
                    elif event.key == pygame.K_r:
                        ai = GomokuAI()
                        game_mode =None
                        game_over = False
                        current_player = 1
                        break
if __name__ == "__main__":
    main()
