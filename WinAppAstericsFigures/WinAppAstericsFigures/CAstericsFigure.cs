using System;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    class CAstericsFigure
    {
        //Datos Miembro - atributos de la clase
        private int mNum, mRow, mA, mB;
        private String mBlanks, mAsterics, mTotalString;

        //Constructor por defecto o sin parametros
        public CAstericsFigure()
        {
            mNum = mRow = 0;
            mBlanks = mAsterics = mTotalString = "";
        }

        //Funciones miembro - Metodos de la clase
        public void InitializeData(TextBox txtNum,
                                   ListBox lstFigure)
        {
            mNum = 0; mRow = 0;
            txtNum.Clear();
            txtNum.Focus();
            lstFigure.Items.Clear();
        }
        public void InitializeData(TextBox txtA,
                                   TextBox txtB,
                                   ListBox lstFigure)
        {
            mA = 0; mB = 0;
            txtA.Clear(); txtB.Clear();
            txtA.Focus();
            lstFigure.Items.Clear();
        }
        public Boolean ReadData(TextBox txtNum)
        {
            Boolean Flag;
            try
            {
                mNum = int.Parse(txtNum.Text);
                if (mNum <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum.Clear();
                    txtNum.Focus();
                    Flag = false;
                }
                else
                    Flag = true;

            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Clear();
                txtNum.Focus();
                Flag = false;
            }

            return Flag;
        }
        public Boolean ReadData(TextBox txtA, TextBox txtB)
        {
            Boolean Flag;
            try
            {
                mA = int.Parse(txtA.Text);
                mB = int.Parse(txtB.Text);
                if (mA <= 0 || mB <= 0)
                {
                    MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Clear();
                    txtB.Clear();
                    txtA.Focus();
                    Flag = false;
                }
                else
                    Flag = true;

            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
                txtB.Clear();
                txtA.Focus();
                Flag = false;
            }

            return Flag;
        }
        public void GraphAstericsTriangle(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            //Bucle extreno para controlar filas
            for (mRow = 1; mRow <= mNum; mRow++)
            {
                mBlanks = mAsterics = mTotalString = "";
                //Bucle interno para controlar los espacios en blancos
                for (contBlanks = mNum - mRow; contBlanks > 0; contBlanks--)
                {
                    mBlanks += " ";
                }
                //Bucle interno para controlar los espacios en blancos
                for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                {
                    mAsterics += "*";
                }
                mTotalString = mBlanks + mAsterics;
                lstFigure.Items.Add(mTotalString);
            }
        }

        public void GraphAstericsRombus(TextBox txtNum, ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();
            if ((mNum + 1) % 2 == 0)
            {
                mNum += 1;
                mNum = mNum / 2;
                //Bucle extreno para controlar filas creciente
                for (mRow = 1; mRow <= mNum; mRow++)
                {
                    mBlanks = mAsterics = mTotalString = "";
                    //Bucle interno para controlar los espacios en blancos
                    for (contBlanks = mNum - mRow; contBlanks > 0; contBlanks--)
                    {
                        mBlanks += " ";
                    }
                    //Bucle interno para controlar los espacios en blancos
                    for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                    {
                        mAsterics += "*";
                    }
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }

                //Bucle extreno para controlar filas decreceinte
                for (mRow = mNum - 1; mRow > 0; mRow--)
                {
                    mBlanks = mAsterics = mTotalString = "";
                    //Bucle interno para controlar los espacios en blancos
                    for (contBlanks = mNum - mRow; contBlanks > 0; contBlanks--)
                    {
                        mBlanks += " ";
                    }
                    //Bucle interno para controlar los espacios en blancos
                    for (contAsterics = 1; contAsterics < 2 * mRow; contAsterics++)
                    {
                        mAsterics += "*";
                    }
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
            else
            {
                MessageBox.Show("Error, el rombo no existe !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeData(txtNum, lstFigure);
            }
        }

        public void GraphAstericsRectangle(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            for (mRow = 1; mRow <= mB; mRow++)
            {
                mBlanks = mAsterics = mTotalString = "";
                if (mRow == 1 || mRow == mB)
                {
                    //Bucle interno para controlar la fila superior e inferior
                    for (contAsterics = 1; contAsterics <= mA; contAsterics++)
                    {
                        mAsterics += "╬"; //BUSCAR UN BUEN CARACTER !!!
                    }
                    lstFigure.Items.Add(mAsterics);
                }
                else
                {
                    mAsterics = "╬";
                    //Bucle interno para controlar los espacios en blancos
                    for (contBlanks = 1; contBlanks <= mA - 2; contBlanks++)
                    {
                        mBlanks += "  ";
                    }
                    mTotalString = mAsterics + mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
        }

        public void GraphAstericsSquare(ListBox lstFigure)
        {
            int contBlanks, contAsterics;
            lstFigure.Items.Clear();

            for (mRow = 1; mRow <= mNum; mRow++)
            {
                mBlanks = mAsterics = mTotalString = "";
                if (mRow == 1 || mRow == mNum)
                {
                    //Bucle interno para controlar la fila superior e inferior
                    for (contAsterics = 1; contAsterics <= mNum; contAsterics++)
                    {
                        mAsterics += "╬"; //BUSCAR UN BUEN CARACTER !!!
                    }
                    lstFigure.Items.Add(mAsterics);
                }
                else
                {
                    mAsterics = "╬";
                    //Bucle interno para controlar los espacios en blancos
                    for (contBlanks = 1; contBlanks <= mNum - 2; contBlanks++)
                    {
                        mBlanks += "  ";
                    }
                    mTotalString = mAsterics + mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
        }

        public void GraphAstericsChessBoard(ListBox lstFigure)
        {
            int contAsterics;
            lstFigure.Items.Clear();

            for (mRow = 1; mRow <= mNum; mRow++)
            {
                mBlanks = mAsterics = mTotalString = "";
                if (mRow % 2 == 1)
                {
                    for (contAsterics = 1; contAsterics <= mNum; contAsterics++)
                    {
                        if (contAsterics % 2 == 1)
                            mAsterics += "█"; //BUSCAR UN BUEN CARACTER !!!
                        else
                            mAsterics += "   ";
                    }
                    lstFigure.Items.Add(mAsterics);
                }
                else
                {
                    for (contAsterics = 1; contAsterics <= mNum; contAsterics++)
                    {
                        if (contAsterics % 2 == 0)
                            mAsterics += "█"; //BUSCAR UN BUEN CARACTER !!!
                        else
                            mAsterics += "   ";
                    }
                    lstFigure.Items.Add(mAsterics);
                }
            }
        }

        public void GraphAstericsCircle(ListBox lstFigure) //HACER BIEN
        {
            int contBlanks, contAsterics;
            string mBlanksInterno;
            lstFigure.Items.Clear();
            for (mRow = 1; mRow < mNum; mRow++)
            {
                mBlanks = mAsterics = mBlanksInterno=mTotalString = "";
                if (mRow == 1)
                {
                    for (contBlanks = 1; contBlanks <= mNum - 2; contBlanks++)
                    {
                        mBlanks += "   ";
                    }
                    for (contAsterics = 1; contAsterics <= mNum - 2; contAsterics++)
                    {
                        mAsterics += "©";
                    }
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
                else
                { 
                    mAsterics = "©";
                    for (contBlanks = mRow; contBlanks <= mNum - 2; contBlanks++)
                    {
                        mBlanks += "   ";
                    }
                    for (contBlanks = 1; contBlanks <= mRow*2-1; contBlanks++)
                    {
                        mBlanksInterno += "   ";
                    }
                    mTotalString =mBlanks + mAsterics+ mBlanksInterno+ mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
            mAsterics = "©";
            for (contBlanks = 1; contBlanks <= mNum*2-3; contBlanks++)
            {
                mBlanks += "   ";
            }
            mTotalString = mAsterics+mBlanks + mAsterics;
            lstFigure.Items.Add(mTotalString);

            for (mRow = mNum-1; mRow > 0; mRow--)
            {
                mBlanks = mAsterics = mBlanksInterno = mTotalString = "";
                if (mRow == 1)
                {
                    for (contBlanks = 1; contBlanks <= mNum - 2; contBlanks++)
                    {
                        mBlanks += "   ";
                    }
                    for (contAsterics = 1; contAsterics <= mNum - 2; contAsterics++)
                    {
                        mAsterics += "©";
                    }
                    mTotalString = mBlanks + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
                else
                {
                    mAsterics = "©";
                    for (contBlanks = mRow; contBlanks <= mNum - 2; contBlanks++)
                    {
                        mBlanks += "   ";
                    }
                    for (contBlanks = 1; contBlanks <= mRow * 2 - 1; contBlanks++)
                    {
                        mBlanksInterno += "   ";
                    }
                    mTotalString = mBlanks + mAsterics + mBlanksInterno + mAsterics;
                    lstFigure.Items.Add(mTotalString);
                }
            }
        }
    }
}
