using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    class Wolfs : Animal
    {
        protected char Woolfs = 'W';
        public void GenerationWolfsinMatrix(int numberWolfs)
        {
            char Woolfs = 'W';
            GenerationAnimal(Woolfs, numberWolfs);
        }
        public void MoveWolfs()
        {
            Motion(Woolfs);
            Multiply();
            base.Multiply();
            CountAnimal();
        }
        protected override void Multiply()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[j, i] == 'O')
                    {
                        if (i == 0 & j == 0)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (i == 0)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i + 1, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (i == 0 & j == _LengthX - 1)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' & Matrix[i, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (j == 0)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W' || Matrix[i - 1, j + 1] == 'W' & Matrix[i - 1, j] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (j == 0 & i == _LengthY - 1)
                        {
                            if (Matrix[i - 1, j] == 'W' || Matrix[i - 1, j + 1] == 'W' || Matrix[i, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (j == _LengthX - 1)
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i - 1, j] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else if (j == _LengthX - 1 & i == _LengthY - 1)
                        {
                            if (Matrix[i - 1, j] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }

                        else
                        {
                            if (Matrix[i + 1, j] == 'W' || Matrix[i + 1, j - 1] == 'W' || Matrix[i, j - 1] == 'W' || Matrix[i - 1, j - 1] == 'W' || Matrix[i - 1, j] == 'W' || Matrix[i - 1, j + 1] == 'W' ||
                                Matrix[i, j + 1] == 'W' || Matrix[i + 1, j + 1] == 'W')
                            {
                                newMatrix[i, j] = 'W';
                            }
                            else
                            {
                                newMatrix[i, j] = 'O';
                            }
                        }
                    }
                    else
                    {
                        newMatrix[i, j] = Matrix[i, j];
                    }
                }
            }

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[j, i] == 'W' & _numberOfmoves == 4)
                    {
                        Matrix[i, j] = '0';
                    }
                }
            }

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = newMatrix[i, j];
                    newMatrix[i, j] = '0';
                }
            }
        }
    }
}
