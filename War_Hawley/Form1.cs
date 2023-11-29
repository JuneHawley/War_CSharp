/*
 * War
 * Hawley
 * 11/28-29/23
 * DDA
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War_Hawley
{
    public partial class WarForm : Form
    {
        private int playerScore;
        private int computerScore;
        private Deck playerDeck;
        private Deck computerDeck;

        public WarForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            playerScore = 0;
            computerScore = 0;
            playerScoreTextBox.Text = playerScore.ToString();
            computerScoreTextBox.Text = computerScore.ToString();

            playButton.Enabled = true;
            restartButton.Enabled = false;

            Deck mainDeck = new Deck();

            List<Card> playerCards = new List<Card>();
            List<Card> computerCards = new List<Card>();

            while (mainDeck.CountRemainingCards() > 0)
            {
                playerCards.Add(mainDeck.GetRandomCard(rng));
                computerCards.Add(mainDeck.GetRandomCard(rng));
            }

            playerDeck = new Deck(playerCards);
            computerDeck = new Deck(computerCards);

            playerPictureBox.Image = Properties.Resources.beach_back;
            computerPictureBox.Image = Properties.Resources.beach_back;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Card playerCard = playerDeck.GetTopCard();
            Card computerCard = computerDeck.GetTopCard();
            // Update scores
            if (playerCard.ComepareTo(computerCard) < 0)
            {
                computerScore += 2;
            }
            else if (playerCard.ComepareTo(computerCard) > 0)
            {
                playerScore += 2;
            }
            else
            {
                computerScore++;
                playerScore++;
            }
            playerScoreTextBox.Text = playerScore.ToString();
            computerScoreTextBox.Text = computerScore.ToString();

            //Update pictures
            playerPictureBox.Image = GetCardImage(playerCard);
            computerPictureBox.Image = GetCardImage(computerCard);

            //Has either player ran out of cards
            if(playerDeck.CountRemainingCards() == 0)
            {
                playButton.Enabled = false;
                restartButton.Enabled = true;
                if (playerScore > computerScore)
                {
                    MessageBox.Show("You have won!", "Game Over");
                }
                else if(computerScore > playerScore)
                {
                    MessageBox.Show("The computer won!", "Game Over");
                }
                else
                {
                    MessageBox.Show("It was a tie...", "Game Over");
                }
            }
        }

        private Image GetCardImage(Card c)
        {
            if (c.Suit == Suit.Clubs)
            {
                if (c.Face == Face.Ace)
                {
                    return Properties.Resources.club_ace;
                }
                else if (c.Face == Face.Two)
                {
                    return Properties.Resources.club_two;
                }
                else if (c.Face == Face.Three)
                {
                    return Properties.Resources.club_three;
                }
                else if (c.Face == Face.Four)
                {
                    return Properties.Resources.club_four;
                }
                else if (c.Face == Face.Five)
                {
                    return Properties.Resources.club_five;
                }
                else if (c.Face == Face.Six)
                {
                    return Properties.Resources.club_six;
                }
                else if (c.Face == Face.Seven)
                {
                    return Properties.Resources.club_seven;
                }
                else if (c.Face == Face.Eight)
                {
                    return Properties.Resources.club_eight;
                }
                else if (c.Face == Face.Nine)
                {
                    return Properties.Resources.club_nine;
                }
                else if (c.Face == Face.Ten)
                {
                    return Properties.Resources.club_ten;
                }
                else if (c.Face == Face.Jack)
                {
                    return Properties.Resources.club_jack;
                }
                else if (c.Face == Face.Queen)
                {
                    return Properties.Resources.club_queen;
                }
                else if (c.Face == Face.King)
                {
                    return Properties.Resources.club_king;
                }
            }

            if (c.Suit == Suit.Diamond)
            {
                if (c.Face == Face.Ace)
                {
                    return Properties.Resources.diamond_ace;
                }
                else if (c.Face == Face.Two)
                {
                    return Properties.Resources.diamond_two;
                }
                else if (c.Face == Face.Three)
                {
                    return Properties.Resources.diamond_three;
                }
                else if (c.Face == Face.Four)
                {
                    return Properties.Resources.diamond_four;
                }
                else if (c.Face == Face.Five)
                {
                    return Properties.Resources.diamond_five;
                }
                else if (c.Face == Face.Six)
                {
                    return Properties.Resources.diamond_six;
                }
                else if (c.Face == Face.Seven)
                {
                    return Properties.Resources.diamond_seven;
                }
                else if (c.Face == Face.Eight)
                {
                    return Properties.Resources.diamond_eight;
                }
                else if (c.Face == Face.Nine)
                {
                    return Properties.Resources.diamond_nine;
                }
                else if (c.Face == Face.Ten)
                {
                    return Properties.Resources.diamond_ten;
                }
                else if (c.Face == Face.Jack)
                {
                    return Properties.Resources.diamond_jack;
                }
                else if (c.Face == Face.Queen)
                {
                    return Properties.Resources.diamond_queen;
                }
                else if (c.Face == Face.King)
                {
                    return Properties.Resources.diamond_king;
                }
            }

            if (c.Suit == Suit.Spades)
            {
                if (c.Face == Face.Ace)
                {
                    return Properties.Resources.spade_ace;
                }
                else if (c.Face == Face.Two)
                {
                    return Properties.Resources.spade_two;
                }
                else if (c.Face == Face.Three)
                {
                    return Properties.Resources.spade_three;
                }
                else if (c.Face == Face.Four)
                {
                    return Properties.Resources.spade_four;
                }
                else if (c.Face == Face.Five)
                {
                    return Properties.Resources.spade_five;
                }
                else if (c.Face == Face.Six)
                {
                    return Properties.Resources.spade_six;
                }
                else if (c.Face == Face.Seven)
                {
                    return Properties.Resources.spade_seven;
                }
                else if (c.Face == Face.Eight)
                {
                    return Properties.Resources.spade_eight;
                }
                else if (c.Face == Face.Nine)
                {
                    return Properties.Resources.spade_nine;
                }
                else if (c.Face == Face.Ten)
                {
                    return Properties.Resources.spade_ten;
                }
                else if (c.Face == Face.Jack)
                {
                    return Properties.Resources.spade_jack;
                }
                else if (c.Face == Face.Queen)
                {
                    return Properties.Resources.spade_queen;
                }
                else if (c.Face == Face.King)
                {
                    return Properties.Resources.spade_king;
                }
            }

            if (c.Suit == Suit.Hearts)
            {
                if (c.Face == Face.Ace)
                {
                    return Properties.Resources.heart_ace;
                }
                else if (c.Face == Face.Two)
                {
                    return Properties.Resources.heart_two;
                }
                else if (c.Face == Face.Three)
                {
                    return Properties.Resources.heart_three;
                }
                else if (c.Face == Face.Four)
                {
                    return Properties.Resources.heart_four;
                }
                else if (c.Face == Face.Five)
                {
                    return Properties.Resources.heart_five;
                }
                else if (c.Face == Face.Six)
                {
                    return Properties.Resources.heart_six;
                }
                else if (c.Face == Face.Seven)
                {
                    return Properties.Resources.heart_seven;
                }
                else if (c.Face == Face.Eight)
                {
                    return Properties.Resources.heart_eight;
                }
                else if (c.Face == Face.Nine)
                {
                    return Properties.Resources.heart_nine;
                }
                else if (c.Face == Face.Ten)
                {
                    return Properties.Resources.heart_ten;
                }
                else if (c.Face == Face.Jack)
                {
                    return Properties.Resources.heart_jack;
                }
                else if (c.Face == Face.Queen)
                {
                    return Properties.Resources.heart_queen;
                }
                else if (c.Face == Face.King)
                {
                    return Properties.Resources.heart_king;
                }
            }
            return Properties.Resources.beach_back;
        }
    }
}