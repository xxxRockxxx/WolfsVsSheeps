using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    public class Animal
    {
        protected int _numberOfAnimal;
        private int _direction_of_travel;
        protected int _x;
        protected int _y;
        protected int _oldMatrix_x;
        protected int _oldMatrix_y;
        protected bool _WokrGame = true;
        protected char[,] Matrix;
        protected char[,] newMatrix;
        protected int _LengthX;
        protected int _LengthY;
        protected int _numberOfmoves;
        protected int _countSheeps;
        protected int _countWolfs;

        public void GenerationMatrix(int numberOfAnimals)
        {
            _LengthX = numberOfAnimals * 2;
            _LengthY = numberOfAnimals * 2;
            Matrix = new char[_LengthX, _LengthY];
            newMatrix = new char[_LengthX, _LengthY];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = '0';
                    newMatrix[i, j] = '0';
                }
            }
        }

        protected void GenerationAnimal(char nameAnimal, int numberAnimal)
        {
            Random rnd = new Random();
            _oldMatrix_x = rnd.Next(0, _LengthX);
            _oldMatrix_y = rnd.Next(0, _LengthY);
            int count = 0;
            while (count < numberAnimal)
            {
                if (Matrix[_oldMatrix_x, _oldMatrix_y] == '0')
                {
                    Matrix[_oldMatrix_x, _oldMatrix_y] = nameAnimal;
                    count++;
                }
            }
        }


        protected void Motion(char Animal)
        {
            _oldMatrix_y = 0;

            while (_oldMatrix_y != _LengthY)
            {
                if (Matrix[_oldMatrix_x, _oldMatrix_y] == Animal)
                {
                    if (_y == 0 & _x == 0)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_y >= 0 & _x >= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_x == 0)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_x >= 0 & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_y == _LengthY - 1)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_y <= 0 & _x >= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_y == 0 & _x == _LengthX - 1)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_y >= 0 & _x <= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_x == _LengthX - 1)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (_x <= 0 & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_x == _LengthX - 1 & _y == _LengthY - 1)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_x <= 0 & _y <= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_y == 0)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_y >= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else if (_y == _LengthY - 1)
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if ((_y <= 0) & (Matrix[_x, _y] == '0'))
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }

                    else
                    {
                        while (newMatrix[_x, _y] != Matrix[_oldMatrix_x, _oldMatrix_y])
                        {
                            GenerateNumber();
                            _x = _oldMatrix_x;
                            _y = _oldMatrix_y;
                            ChooseMotion();
                            if (Matrix[_x, _y] == '0')
                            {
                                newMatrix[_x, _y] = Matrix[_oldMatrix_x, _oldMatrix_y];
                            }
                        }
                    }
                }
                _oldMatrix_x++;
                if (_oldMatrix_x == _LengthX)
                {
                    _oldMatrix_x = 0;
                    _oldMatrix_y++;
                }
            }
            _numberOfmoves++;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[j, i] = newMatrix[j, i];
                    newMatrix[j, i] = '0';
                }
            }
        }

        protected virtual void Multiply()
        {
            if (_numberOfmoves == 4)
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] == 'O')
                        {
                            if (i == 0 & j == 0)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';

                                }
                            }
                            else if (i == 0)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i + 1, j - 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';

                                }
                            }

                            else if (i == 0 & j == _LengthX - 1)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';

                                }
                            }
                            else if (j == 0)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j + 1] == '0' & Matrix[i, j + 1] == '0' & Matrix[i - 1, j + 1] == '0' & Matrix[i - 1, j] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';
                                }
                            }
                            else if (j == 0 & i == _LengthY - 1)
                            {
                                if (Matrix[i - 1, j] == '0' & Matrix[i - 1, j + 1] == '0' & Matrix[i, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';
                                }
                            }
                            else if (j == _LengthX - 1)
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i - 1, j] == '0')
                                {
                                    Matrix[i, j - 1] = 'O';
                                }
                            }
                            else if (j == _LengthX - 1 & i == _LengthY - 1)
                            {
                                if (Matrix[i - 1, j] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i, j - 1] == '0')
                                {
                                    Matrix[i, j - 1] = 'O';
                                }

                            }
                            else
                            {
                                if (Matrix[i + 1, j] == '0' & Matrix[i + 1, j - 1] == '0' & Matrix[i, j - 1] == '0' & Matrix[i - 1, j - 1] == '0' & Matrix[i - 1, j] == '0' & Matrix[i - 1, j + 1] == '0' &
                                    Matrix[i, j + 1] == '0' & Matrix[i + 1, j + 1] == '0')
                                {
                                    Matrix[i, j + 1] = 'O';
                                }
                            }

                        }

                    }
                }
            }
            _numberOfmoves = 0;
        }

        private void GenerateNumber()
        {
            Random rnd = new Random();
            _direction_of_travel = rnd.Next(0, 8);
        }

        private void ChooseMotion()
        {
            switch (_direction_of_travel)
            {
                case 0:
                    _y--;
                    break;
                case 1:
                    _y++;
                    break;
                case 2:
                    _x--;
                    break;
                case 3:
                    _x++;
                    break;
                case 4:
                    _x++;
                    _y++;
                    break;
                case 5:
                    _y++;
                    _x--;
                    break;
                case 6:
                    _x--;
                    _y--;
                    break;
                case 7:
                    _x++;
                    _y--;
                    break;
            }
        }
        protected void CountAnimal()
        {
            _countSheeps = 0;
            _countWolfs = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 'O')
                    {
                        _countSheeps++;
                    }
                    else if (Matrix[i, j] == 'W')
                    {
                        _countWolfs++;
                    }
                }
            }

            if(_countWolfs==0 || _countSheeps == 0)
            {
                _WokrGame = false;
            }
        }
        


    }
}


