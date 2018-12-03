private void AI_move()
{
    /*
     * AI rules!
     * rule 1 : get 3 in a row
     * rule 2: stop 3 in a row
     * rule 3: go for center tile
     * rule 4: go for corner tile
     * rule 5: just pick what eve is left
     */
    /* 
           move = win_Or_Block("O");//look for the  win
               if (move == null)
               {
                   move = win_Or_Block("X");//look for the block
                   if (move == null)
                   {
                       move = center_tile();//always get center tile
                       if (move == null)
                       {
                           move = corner_tile();//get that too
                           if (move == null)
                           {
                               move = open_space();//yeaaah fuck it thats whats left
                           }//end if
                       }//end if
                   }//end if
               }//end if
               if (!match_over)
               { move.PerformClick(); }
           }//end of ai_move

           #region AI logic

           private Case center_tile()
           {
               if (B2.Text == "")
               { return B2; }
               return null;
           }

           private Button open_space()
           {
               Console.WriteLine("Looking for open space");
               Button b = null;
               foreach (Control c in Controls)
               {
                   b = c as Button;
                   if (b != null)
                   {
                       if (b.Text == "")
                           return b;
                   }//end if
               }//end if

               return null;
           }

           private Button corner_tile()
           {
               Console.WriteLine("Looking for corner");
               if (A1.Text == "O")
               {
                   if (A3.Text == "")
                       return A3;
                   if (C3.Text == "")
                       return C3;
                   if (C1.Text == "")
                       return C1;
               }

               if (A3.Text == "O")
               {
                   if (A1.Text == "")
                       return A1;
                   if (C3.Text == "")
                       return C3;
                   if (C1.Text == "")
                       return C1;
               }

               if (C3.Text == "O")
               {
                   if (A1.Text == "")
                       return A3;
                   if (A3.Text == "")
                       return A3;
                   if (C1.Text == "")
                       return C1;
               }

               if (C1.Text == "O")
               {
                   if (A1.Text == "")
                       return A3;
                   if (A3.Text == "")
                       return A3;
                   if (C3.Text == "")
                       return C3;
               }

               if (A1.Text == "")
                   return A1;
               if (A3.Text == "")
                   return A3;
               if (C1.Text == "")
                   return C1;
               if (C3.Text == "")
                   return C3;

               return null;
           }

           private Button win_Or_Block(string mark)
           {
               Console.WriteLine("Looking for win or block:  " + mark);
               //HORIZONTAL TESTS
               if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                   return A3;
               if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                   return A1;
               if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                   return A2;

               if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                   return B3;
               if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                   return B1;
               if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                   return B2;

               if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                   return C3;
               if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                   return C1;
               if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                   return C2;

               //VERTICAL TESTS
               if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                   return C1;
               if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                   return A1;
               if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                   return B1;

               if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                   return C2;
               if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                   return A2;
               if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                   return B2;

               if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                   return C3;
               if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                   return A3;
               if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                   return B3;

               //DIAGONAL TESTS
               if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                   return C3;
               if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                   return A1;
               if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                   return B2;

               if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                   return C1;
               if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                   return A3;
               if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                   return B2;

               return null;
           }

           #endregion AI logic

           //end of A.I Logic*/
}
