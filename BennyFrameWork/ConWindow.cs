using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BennyFrameWork
{using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BennyFrameWork
{
    public class ConWindow
    {
        public ConWindow()
        {

        }




        // margin and padding planned
        public void DrawWindow(int left, int top)
        {

            const int minWindowSize = 15;
            // checks if values are big enough to resize the window to left and top
            int winTop = (top < minWindowSize) ? minWindowSize : top;
            int winLeft = (left < minWindowSize*2) ? minWindowSize*2 : left;

            System.Console.SetWindowSize(winLeft, winTop);
            System.Console.SetBufferSize(winLeft, winTop);


            // ┌ ─ ┐
            // └ ─ ┘
            for (int y = 0; y <= top+1; y++)
            {
                // the console framework prints strings very slow
                // so we have to prepare a string to print in one call
                string lineToDraw = "";

                for (int x = 0; x <= left; x++)
                {

                    Console.SetCursorPosition(0, y);

                    // TOP if this is the first char
                    if (x == 0)
                    {
                        // if this is the first row
                        if (y == 0)
                        {
                            lineToDraw += "┌";
                        } // if this is the Last row
                        else if(y == top+1)
                        {
                            lineToDraw += "└";
                        }
                        else
                        {
                            lineToDraw += "│";
                        }
                    } 
                    

                    // BOTTOM if this is the last char
                    if (x == left)
                    {
                        // if this is the first row
                        if (y == 0)
                        {
                            lineToDraw += "┐";
                        } // if this is the Last row
                        else if (y == top+1)
                        {
                            lineToDraw += "┘";
                        }
                        else
                        {
                            lineToDraw += "│";
                        }
                    }
                    else
                    {
                        // MIDDLE if this is the first or last row
                        if (y == 0 || y == top + 1)
                        {
                            lineToDraw += "─";
                        }
                        else
                        {
                            lineToDraw += " ";
                        }
                    }
                }
                Console.WriteLine(lineToDraw);
            }

            Console.SetCursorPosition(0, 0);

        }
            // ├ ─ ┤


    }
}

}
