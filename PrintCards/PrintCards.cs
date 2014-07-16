using System;

class PrintCards
{
    static char diamond = '\u2666';
    static char spade = '\u2660';
    static char club = '\u2663';
    static char hearth = '\u2665';
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int cards = 2; cards <= 14; cards++)
        {
            switch (cards)
            {
                case 11:
                    char figureJ = 'J';
                    PrintCards(figureJ);
                    break;
                case 12:
                    char figureD = 'D';
                    PrintCards(figureD);
                    break;
                case 13:
                    char figureK = 'K';
                    PrintCards(figureK);
                    break;
                case 14:
                    char figureA = 'A';
                    PrintCards(figureA);
                    break;
                    
                default:
                   Console.WriteLine("{0,2}{1} {0,2}{2} {0,2}{3} {0,2}{4}", cards, club, diamond, hearth, spade);
                    break;
            }
         }     
      }

    static void PrintCards(char figure)
    {
        Console.WriteLine("{0,2}{1} {0,2}{2} {0,2}{3} {0,2}{4}", figure, club, diamond, hearth, spade);
    }
}

