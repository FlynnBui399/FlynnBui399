import pygame
import random
import time
import os
import sys
# Getting Dir of assets
base_dir=os.path.dirname(os.path.abspath(__file__))
image_path=os.path.join(base_dir,"assets","images")
font_path=os.path.join(base_dir,"assets","fonts")
# Constants color
WIDTH, HEIGHT = 700, 700
BOARD_SIZE = 15
CELL_SIZE = WIDTH // BOARD_SIZE
BLACK = (0, 0, 0)
WHITE = (255, 255, 255)
RED =(255, 41, 41)
GRAY = (200, 200, 200)
BROWN = (130, 91, 50)
YELLOW =(255,241,0)

# Create the screen
screen = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Gomoku")
# Preprocessing image and set font
icn = pygame.image.load(os.path.join(image_path, "gmk_icon.png"))
resized_icn = pygame.transform.smoothscale(icn, (100, 100))
backgr=pygame.image.load(os.path.join(image_path,"painting_backgr.jpg"))
resized_backgr = pygame.transform.smoothscale(backgr,(700,700))
pygame.display.set_icon(icn)

#Display infor of members
def draw_infor_members():
    font = pygame.font.Font(None, 20)
    member0 = font.render("Huynh Gia Han - 23110019", True, BLACK)
    member1 = font.render("Bui Tran Tan Phat - 23110052", True, BLACK)
    member2 = font.render("Nguyen Nhat Phat - 23110053", True, BLACK)
    member3 = font.render("Tran Huynh Xuan Thanh - 23110060", True, BLACK)
    margin = 10  # distance from bottom and right margin
    screen.blit(member0, (700 - member0.get_width() - margin, 700 - (member0.get_height()+3) * 4 - margin))
    screen.blit(member1, (700 - member1.get_width() - margin, 700 - (member1.get_height()+3)* 3 - margin))
    screen.blit(member2, (700 - member2.get_width() - margin, 700 - member2.get_height() * 2 - margin))
    screen.blit(member3, (700 - member3.get_width() - margin, 700 - member3.get_height() - margin))
# Display menu
def draw_menu():
    resized_backgr = pygame.transform.scale(backgr,(700,700))
    font = pygame.font.Font(None, 40)
    title_font= pygame.font.Font(os.path.join(font_path, "FiraCode-Bold.ttf"), 70)
    title = title_font.render("Gomoku", True, BLACK)
    option1 = font.render("1. Play against AI", True, YELLOW)
    option2 = font.render("2. Two Player Mode", True, YELLOW)
    screen.blit(resized_backgr,(0,0))
    screen.blit(resized_icn,((WIDTH // 2) - (title.get_width() // 2)+80, ((HEIGHT // 2)-220))) # Position for icn
    screen.blit(title, ((WIDTH // 2) - (title.get_width() // 2), HEIGHT// 3))
    screen.blit(option1, (WIDTH // 2 - 100, HEIGHT // 2))
    screen.blit(option2, (WIDTH // 2 - 100, HEIGHT // 2 + 50))
    draw_infor_members()
    pygame.display.flip()

# Check who won and display end screen
def check_over(game_over, current_player):
     if game_over:
        font = pygame.font.Font(os.path.join(font_path, "FiraCode-Bold.ttf"), 40)
        messagesshow = ""
        if current_player == 1:
            messagesshow = "Black won!"
        elif current_player == -1:
            messagesshow = "White won!"
        else:
            messagesshow = "It's a draw!"
        # Set backgr
        rect_width = 300
        rect_height = 150
        rect_x = (WIDTH // 2) - (rect_width // 2)
        rect_y = (HEIGHT // 2) - (rect_height // 2)
        # Draw rectangle box
        pygame.draw.rect(screen, (0, 0, 0), (rect_x, rect_y, rect_width, rect_height))
        pygame.draw.rect(screen, (255, 255, 255), (rect_x + 5, rect_y + 5, rect_width - 10, rect_height - 10))
        # Dialog
        won_text = font.render(messagesshow, True, BLACK)
        screen.blit(won_text, ((WIDTH // 2) - (won_text.get_width() // 2), HEIGHT // 2 - 55))
        # Show introduction
        instruction_font = pygame.font.Font(os.path.join(font_path, "FiraCode-Bold.ttf"), 26)
        return_txt = instruction_font.render("Press R: menu", True, BLACK)
        screen.blit(return_txt, ((WIDTH // 2) - (return_txt.get_width() // 2),HEIGHT // 2 + 10))
        esc_txt = instruction_font.render("Press ESC to exit", True, BLACK)
        screen.blit(esc_txt, ((WIDTH // 2) - (esc_txt.get_width() // 2), HEIGHT // 2 + 40))
        pygame.display.flip()
        
