using System;
using System.Collections.Generic;
using System.Text;

namespace Trik
{
    public class TrikGame
    {
        readonly char PatternA = 'A';
        readonly char PatternB = 'B';
        readonly char PatternC = 'C';

        private enum PositionOfGlass
        {
            Left = 1,
            Center = 2,
            Right = 3
        }

        private int position { get; set; } = 1;
        public int Position { get => position; }
        private string inputPosition { get; set; } 

        public TrikGame(string input)
        {
            if(!isValid(input))
            {
                throw new ArgumentException("Input Invalid");
            }

            inputPosition = input;
        }

        public void FindPositionOfBall()
        {
            position = FindPositionUseNormal();
        }

        private int FindPositionUseNormal()
        {
            int current = position;
            for(int i = 0; i < inputPosition.Length; i++)
            {
                if(inputPosition[i] == PatternA)
                {
                    if(current == (int)PositionOfGlass.Left)
                    {
                        MoveNextOneStep(ref current);
                    }
                    else if(current == (int)PositionOfGlass.Center)
                    {
                        BackwardOneStep(ref current);
                    }
                }
                else if(inputPosition[i] == PatternB)
                {
                    if (current == (int)PositionOfGlass.Center)
                    {
                        MoveNextOneStep(ref current);
                    }
                    else if (current == (int)PositionOfGlass.Right)
                    {
                        BackwardOneStep(ref current);
                    }
                }
                else if(inputPosition[i] == PatternC)
                {
                    if (current == (int)PositionOfGlass.Left)
                    {
                        MoveNextTwoStep(ref current);
                    }
                    else if (current == (int)PositionOfGlass.Right)
                    {
                        BackwardTwoStep(ref current);
                    }
                }
            }

            return current;
        }


        private void MoveNextOneStep(ref int current)
        {
            current += 1;
        }
        private void MoveNextTwoStep(ref int current)
        {
            current += 2;
        }

        private void BackwardOneStep(ref int current)
        {
            current -= 1;
        }

        private void BackwardTwoStep(ref int current)
        {
            current -= 2;
        }

        private bool isValid(string input)
        {
            List<char> GroupCharacterValidate = new List<char>()
            {
                'A','B','C'
            };

            for(int i = 0; i < input.Length; i++)
            {
                if(!GroupCharacterValidate.Contains(input[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
