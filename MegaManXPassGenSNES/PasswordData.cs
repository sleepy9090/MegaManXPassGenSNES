namespace MegaManXPassGenSNES
{
    public class PasswordData
    {


        public PasswordData()
        {
            X1Y1 = 0;
            X1Y2 = 0;
            X1Y3 = 0;

            X2Y1 = 0;
            X2Y2 = 0;
            X2Y3 = 0;

            X3Y1 = 0;
            X3Y2 = 0;
            X3Y3 = 0;

            X4Y1 = 0;
            X4Y2 = 0;
            X4Y3 = 0;
        }

        public int PasswordSet
        {
            get;
            set;
        }

        public bool DefeatedChillPenguin
        {
            get;
            set;
        }

        public bool DefeatedStormEagle
        {
            get;
            set;
        }

        public bool DefeatedFlameMammoth
        {
            get;
            set;
        }

        public bool DefeatedStingChameleon
        {
            get;
            set;
        }

        public bool DefeatedSparkMandrill
        {
            get;
            set;
        }

        public bool DefeatedArmoredArmadillo
        {
            get;
            set;
        }

        public bool DefeatedBoomerKuwanger
        {
            get;
            set;
        }

        public bool DefeatedLaunchOctopus
        {
            get;
            set;
        }

        public bool AcquiredHeartTankChillPenguin
        {
            get;
            set;
        }

        public bool AcquiredHeartTankStormEagle
        {
            get;
            set;
        }

        public bool AcquiredHeartTankFlameMammoth
        {
            get;
            set;
        }

        public bool AcquiredHeartTankStingChameleon
        {
            get;
            set;
        }

        public bool AcquiredHeartTankSparkMandrill
        {
            get;
            set;
        }

        public bool AcquiredHeartTankArmoredArmadillo
        {
            get;
            set;
        }

        public bool AcquiredHeartTankBoomerKuwanger
        {
            get;
            set;
        }

        public bool AcquiredHeartTankLaunchOctopus
        {
            get;
            set;
        }

        public bool AcquiredSubTankStormEagle
        {
            get;
            set;
        }

        public bool AcquiredSubTankFlameMammoth
        {
            get;
            set;
        }

        public bool AcquiredSubTankSparkMandrill
        {
            get;
            set;
        }

        public bool AcquiredSubTankArmoredArmadillo
        {
            get;
            set;
        }

        public bool AcquiredBoots
        {
            get;
            set;
        }

        public bool AcquiredHelmet
        {
            get;
            set;
        }

        public bool AcquiredArmor
        {
            get;
            set;
        }

        public bool AcquiredXBuster
        {
            get;
            set;
        }

        public int X1Y1
        {
            get;
            set;
        }

        public int X1Y2
        {
            get;
            set;
        }

        public int X1Y3
        {
            get;
            set;
        }

        public int X2Y1
        {
            get;
            set;
        }

        public int X2Y2
        {
            get;
            set;
        }

        public int X2Y3
        {
            get;
            set;
        }

        public int X3Y1
        {
            get;
            set;
        }

        public int X3Y2
        {
            get;
            set;
        }

        public int X3Y3
        {
            get;
            set;
        }

        public int X4Y1
        {
            get;
            set;
        }

        public int X4Y2
        {
            get;
            set;
        }

        public int X4Y3
        {
            get;
            set;
        }

        private int[] X1Y1Values
        {
            get;
            set;
        }

        private int[] X1Y2Values
        {
            get;
            set;
        }

        private int[] X1Y3Values
        {
            get;
            set;
        }

        private int[] X2Y1Values
        {
            get;
            set;
        }

        private int[] X2Y2Values
        {
            get;
            set;
        }

        private int[] X2Y3Values
        {
            get;
            set;
        }

        private int[] X3Y1Values
        {
            get;
            set;
        }

        private int[] X3Y2Values
        {
            get;
            set;
        }

        private int[] X3Y3Values
        {
            get;
            set;
        }

        private int[] X4Y1Values
        {
            get;
            set;
        }

        private int[] X4Y2Values
        {
            get;
            set;
        }

        private int[] X4Y3Values
        {
            get;
            set;
        }

        public void GeneratePassword()
        {
            PopulatePasswordSet();

            bool[] x1y1FactorBools =
            {
                DefeatedArmoredArmadillo, DefeatedBoomerKuwanger, AcquiredHeartTankBoomerKuwanger,AcquiredHeartTankChillPenguin, AcquiredHeartTankFlameMammoth,
                AcquiredHeartTankLaunchOctopus, AcquiredHeartTankStingChameleon, AcquiredHeartTankSparkMandrill, AcquiredArmor
            };

            bool[] x3y1FactorBools = {
                DefeatedArmoredArmadillo, DefeatedBoomerKuwanger, DefeatedChillPenguin, DefeatedFlameMammoth, DefeatedLaunchOctopus, DefeatedSparkMandrill,
                DefeatedStingChameleon, DefeatedStormEagle
            };

            bool[] x1y2FactorBools = {
                DefeatedArmoredArmadillo, DefeatedBoomerKuwanger, DefeatedChillPenguin, DefeatedFlameMammoth, DefeatedStormEagle, AcquiredHeartTankArmoredArmadillo,
                AcquiredHeartTankBoomerKuwanger, AcquiredSubTankArmoredArmadillo, AcquiredXBuster
            };

            bool[] x2y2FactorBools = {
                AcquiredSubTankArmoredArmadillo, AcquiredSubTankFlameMammoth, AcquiredSubTankSparkMandrill, AcquiredSubTankStormEagle, AcquiredBoots, AcquiredHelmet,
                AcquiredArmor, AcquiredXBuster
            };

            bool[] x3y2FactorBools = {
                DefeatedLaunchOctopus, DefeatedStormEagle, AcquiredHeartTankChillPenguin, AcquiredHeartTankFlameMammoth, AcquiredSubTankStormEagle, AcquiredHelmet
            };

            bool[] x1y3FactorBools = {
                DefeatedChillPenguin, DefeatedFlameMammoth, AcquiredHeartTankLaunchOctopus, AcquiredHeartTankStingChameleon, AcquiredSubTankSparkMandrill,
                AcquiredSubTankStormEagle, AcquiredHelmet, AcquiredArmor, AcquiredXBuster
            };

            bool[] x2y3FactorBools = {
                AcquiredHeartTankArmoredArmadillo, AcquiredHeartTankBoomerKuwanger, AcquiredHeartTankChillPenguin, AcquiredHeartTankFlameMammoth,
                AcquiredHeartTankLaunchOctopus, AcquiredHeartTankSparkMandrill, AcquiredHeartTankStingChameleon, AcquiredHeartTankStormEagle
            };

            if (AcquiredHeartTankArmoredArmadillo && AcquiredBoots)
            {
                X1Y1 = IsPositionFactorsEven(x1y1FactorBools) ? X1Y1Values[6] : X1Y1Values[7];
            }
            else if (AcquiredHeartTankArmoredArmadillo)
            {
                X1Y1 = IsPositionFactorsEven(x1y1FactorBools) ? X1Y1Values[2] : X1Y1Values[3];
            }
            else if (AcquiredBoots)
            {
                X1Y1 = IsPositionFactorsEven(x1y1FactorBools) ? X1Y1Values[4] : X1Y1Values[5];
            }
            else
            {
                X1Y1 = IsPositionFactorsEven(x1y1FactorBools) ? X1Y1Values[0] : X1Y1Values[1];
            }

            if (DefeatedStingChameleon && AcquiredSubTankStormEagle)
            {
                X2Y1 = X2Y1Values[3];
            }
            else if (AcquiredSubTankStormEagle)
            {
                X2Y1 = X2Y1Values[2];
            }
            else if (DefeatedStingChameleon)
            {
                X2Y1 = X2Y1Values[1];
            }
            else
            {
                X2Y1 = X2Y1Values[0];
            }

            if (AcquiredHeartTankLaunchOctopus && AcquiredSubTankSparkMandrill)
            {
                X3Y1 = IsPositionFactorsEven(x3y1FactorBools) ? X3Y1Values[6] : X3Y1Values[7];
            }
            else if (AcquiredHeartTankLaunchOctopus)
            {
                X3Y1 = IsPositionFactorsEven(x3y1FactorBools) ? X3Y1Values[2] : X3Y1Values[3];
            }
            else if (AcquiredSubTankSparkMandrill)
            {
                X3Y1 = IsPositionFactorsEven(x3y1FactorBools) ? X3Y1Values[4] : X3Y1Values[5];
            }
            else
            {
                X3Y1 = IsPositionFactorsEven(x3y1FactorBools) ? X3Y1Values[0] : X3Y1Values[1];
            }

            if (DefeatedChillPenguin && AcquiredHeartTankSparkMandrill)
            {
                X4Y1 = X4Y1Values[3];
            }
            else if (AcquiredHeartTankSparkMandrill)
            {
                X4Y1 = X4Y1Values[2];
            }
            else if (DefeatedChillPenguin)
            {
                X4Y1 = X4Y1Values[1];
            }
            else
            {
                X4Y1 = X4Y1Values[0];
            }

            if (DefeatedLaunchOctopus && AcquiredArmor)
            {
                X1Y2 = IsPositionFactorsEven(x1y2FactorBools) ? X1Y2Values[6] : X1Y2Values[7];
            }
            else if (DefeatedLaunchOctopus)
            {
                X1Y2 = IsPositionFactorsEven(x1y2FactorBools) ? X1Y2Values[2] : X1Y2Values[3];
            }
            else if (AcquiredArmor)
            {
                X1Y2 = IsPositionFactorsEven(x1y2FactorBools) ? X1Y2Values[4] : X1Y2Values[5];
            }
            else
            {
                X1Y2 = IsPositionFactorsEven(x1y2FactorBools) ? X1Y2Values[0] : X1Y2Values[1];
            }

            if (DefeatedBoomerKuwanger && AcquiredHeartTankBoomerKuwanger)
            {
                X2Y2 = IsPositionFactorsEven(x2y2FactorBools) ? X2Y2Values[6] : X2Y2Values[7];
            }
            else if (DefeatedBoomerKuwanger)
            {
                X2Y2 = IsPositionFactorsEven(x2y2FactorBools) ? X2Y2Values[2] : X2Y2Values[3];
            }
            else if (AcquiredHeartTankBoomerKuwanger)
            {
                X2Y2 = IsPositionFactorsEven(x2y2FactorBools) ? X2Y2Values[4] : X2Y2Values[5];
            }
            else
            {
                X2Y2 = IsPositionFactorsEven(x2y2FactorBools) ? X2Y2Values[0] : X2Y2Values[1];
            }

            if (DefeatedArmoredArmadillo && AcquiredXBuster)
            {
                X3Y2 = IsPositionFactorsEven(x3y2FactorBools) ? X3Y2Values[6] : X3Y2Values[7];
            }
            else if (DefeatedArmoredArmadillo)
            {
                X3Y2 = IsPositionFactorsEven(x3y2FactorBools) ? X3Y2Values[2] : X3Y2Values[3];
            }
            else if (AcquiredXBuster)
            {
                X3Y2 = IsPositionFactorsEven(x3y2FactorBools) ? X3Y2Values[4] : X3Y2Values[5];
            }
            else
            {
                X3Y2 = IsPositionFactorsEven(x3y2FactorBools) ? X3Y2Values[0] : X3Y2Values[1];
            }

            if (DefeatedSparkMandrill && AcquiredHeartTankStingChameleon)
            {
                X4Y2 = X4Y2Values[3];
            }
            else if (AcquiredHeartTankStingChameleon)
            {
                X4Y2 = X4Y2Values[2];
            }
            else if (DefeatedSparkMandrill)
            {
                X4Y2 = X4Y2Values[1];
            }
            else
            {
                X4Y2 = X4Y2Values[0];
            }

            if (AcquiredHeartTankChillPenguin && AcquiredSubTankArmoredArmadillo)
            {
                X1Y3 = IsPositionFactorsEven(x1y3FactorBools) ? X1Y3Values[6] : X1Y3Values[7];
            }
            else if (AcquiredHeartTankChillPenguin)
            {
                X1Y3 = IsPositionFactorsEven(x1y3FactorBools) ? X1Y3Values[2] : X1Y3Values[3];
            }
            else if (AcquiredSubTankArmoredArmadillo)
            {
                X1Y3 = IsPositionFactorsEven(x1y3FactorBools) ? X1Y3Values[4] : X1Y3Values[5];
            }
            else
            {
                X1Y3 = IsPositionFactorsEven(x1y3FactorBools) ? X1Y3Values[0] : X1Y3Values[1];
            }

            if (AcquiredHeartTankChillPenguin && AcquiredSubTankArmoredArmadillo)
            {
                X2Y3 = IsPositionFactorsEven(x2y3FactorBools) ? X2Y3Values[6] : X2Y3Values[7];
            }
            else if (AcquiredHeartTankChillPenguin)
            {
                X2Y3 = IsPositionFactorsEven(x2y3FactorBools) ? X2Y3Values[2] : X2Y3Values[3];
            }
            else if (AcquiredSubTankArmoredArmadillo)
            {
                X2Y3 = IsPositionFactorsEven(x2y3FactorBools) ? X2Y3Values[4] : X2Y3Values[5];
            }
            else
            {
                X2Y3 = IsPositionFactorsEven(x2y3FactorBools) ? X2Y3Values[0] : X2Y3Values[1];
            }

            if (AcquiredHeartTankFlameMammoth && AcquiredSubTankFlameMammoth)
            {
                X3Y3 = X3Y3Values[3];
            }
            else if (AcquiredSubTankFlameMammoth)
            {
                X3Y3 = X3Y3Values[2];
            }
            else if (AcquiredHeartTankFlameMammoth)
            {
                X3Y3 = X3Y3Values[1];
            }
            else
            {
                X3Y3 = X3Y3Values[0];
            }

            if (DefeatedStormEagle && AcquiredHeartTankStormEagle)
            {
                X4Y3 = X4Y3Values[3];
            }
            else if (AcquiredHeartTankStormEagle)
            {
                X4Y3 = X4Y3Values[2];
            }
            else if (DefeatedStormEagle)
            {
                X4Y3 = X4Y3Values[1];
            }
            else
            {
                X4Y3 = X4Y3Values[0];
            }
        }

        private static bool IsPositionFactorsEven(bool[] factorBools)
        {
            int count = 0;
            bool isEven = false;

            foreach (bool factorBool in factorBools)
            {
                if (factorBool)
                {
                    count++;
                }
            }

            isEven = count % 2 == 0;
            return isEven;
        }

        private void PopulatePasswordSet()
        {
            switch (PasswordSet)
            {
                case 1:
                    X1Y1Values = new[] { 1, 8, 4, 6, 3, 7, 2, 5 };
                    X2Y1Values = new[] { 8, 3, 2, 1 };
                    X3Y1Values = new[] { 2, 6, 8, 7, 5, 3, 4, 1 };
                    X4Y1Values = new[] { 1, 4, 6, 8 };

                    X1Y2Values = new[] { 5, 7, 3, 2, 1, 8, 6, 4 };
                    X2Y2Values = new[] { 8, 2, 4, 7, 1, 3, 6, 5 };
                    X3Y2Values = new[] { 5, 4, 8, 1, 3, 7, 6, 2 };
                    X4Y2Values = new[] { 2, 6, 8, 7 };

                    X1Y3Values = new[] { 4, 1, 2, 7, 6, 5, 8, 3 };
                    X2Y3Values = new[] { 3, 2, 7, 8, 4, 1, 6, 5 };
                    X3Y3Values = new[] { 2, 4, 6, 7 };
                    X4Y3Values = new[] { 5, 3, 2, 6 };

                    break;
                case 2:
                    X1Y1Values = new[] { 2, 5, 3, 7, 4, 6, 1, 8 };
                    X2Y1Values = new[] { 6, 7, 4, 5 };
                    X3Y1Values = new[] { 4, 1, 5, 3, 8, 7, 2, 6 };
                    X4Y1Values = new[] { 8, 6, 4, 1 };

                    X1Y2Values = new[] { 8, 1, 4, 6, 7, 5, 2, 3 };
                    X2Y2Values = new[] { 6, 5, 1, 3, 4, 7, 8, 2 };
                    X3Y2Values = new[] { 6, 2, 3, 7, 8, 1, 5, 4 };
                    X4Y2Values = new[] { 7, 8, 6, 2 };

                    X1Y3Values = new[] { 6, 5, 8, 3, 4, 1, 2, 7 };
                    X2Y3Values = new[] { 7, 8, 3, 2, 6, 5, 4, 1 };
                    X3Y3Values = new[] { 1, 5, 8, 3 };
                    X4Y3Values = new[] { 4, 7, 8, 1 };

                    break;
                case 3:
                    X1Y1Values = new[] { 3, 7, 2, 5, 1, 8, 4, 6 };
                    X2Y1Values = new[] { 8, 3, 2, 1 };
                    X3Y1Values = new[] { 8, 7, 2, 6, 4, 1, 5, 3 };
                    X4Y1Values = new[] { 4, 1, 8, 6 };

                    X1Y2Values = new[] { 5, 7, 3, 2, 1, 8, 6, 4 };
                    X2Y2Values = new[] { 8, 2, 4, 7, 1, 3, 6, 5 };
                    X3Y2Values = new[] { 5, 4, 8, 1, 3, 7, 6, 2 };
                    X4Y2Values = new[] { 8, 7, 2, 6 };

                    X1Y3Values = new[] { 1, 4, 7, 2, 5, 6, 3, 8 };
                    X2Y3Values = new[] { 7, 8, 3, 2, 6, 5, 4, 1 };
                    X3Y3Values = new[] { 6, 7, 2, 4 };
                    X4Y3Values = new[] { 8, 1, 4, 7 };

                    break;
                case 4:
                    X1Y1Values = new[] { 4, 6, 1, 8, 2, 5, 3, 7 };
                    X2Y1Values = new[] { 6, 7, 4, 5 };
                    X3Y1Values = new[] { 5, 3, 4, 1, 2, 6, 8, 7 };
                    X4Y1Values = new[] { 6, 8, 1, 4 };

                    X1Y2Values = new[] { 8, 1, 4, 6, 7, 5, 2, 3 };
                    X2Y2Values = new[] { 6, 5, 1, 3, 4, 7, 8, 2 };
                    X3Y2Values = new[] { 6, 2, 3, 7, 8, 1, 5, 4 };
                    X4Y2Values = new[] { 6, 2, 7, 8 };

                    X1Y3Values = new[] { 5, 6, 3, 8, 1, 4, 7, 2 };
                    X2Y3Values = new[] { 3, 2, 7, 8, 4, 1, 6, 5 };
                    X3Y3Values = new[] { 8, 3, 1, 5 };
                    X4Y3Values = new[] { 2, 6, 5, 3 };

                    break;
                case 5:
                    X1Y1Values = new[] { 5, 2, 7, 3, 6, 4, 8, 1 };
                    X2Y1Values = new[] { 3, 8, 1, 2 };
                    X3Y1Values = new[] { 8, 7, 2, 6, 4, 1, 5, 3 };
                    X4Y1Values = new[] { 4, 1, 8, 6 };

                    X1Y2Values = new[] { 7, 5, 2, 3, 8, 1, 4, 6 };
                    X2Y2Values = new[] { 1, 3, 6, 5, 8, 2, 4, 7 };
                    X3Y2Values = new[] { 3, 7, 6, 2, 5, 4, 8, 1 };
                    X4Y2Values = new[] { 7, 8, 6, 2 };

                    X1Y3Values = new[] { 6, 5, 8, 3, 4, 1, 2, 7 };
                    X2Y3Values = new[] { 7, 8, 3, 2, 6, 5, 4, 1 };
                    X3Y3Values = new[] { 1, 5, 8, 3 };
                    X4Y3Values = new[] { 8, 1, 4, 7 };

                    break;
                case 6:
                    X1Y1Values = new[] { 6, 4, 8, 1, 5, 2, 7, 3 };
                    X2Y1Values = new[] { 3, 8, 1, 2 };
                    X3Y1Values = new[] { 2, 6, 8, 7, 5, 3, 4, 1 };
                    X4Y1Values = new[] { 1, 4, 6, 8 };

                    X1Y2Values = new[] { 7, 5, 2, 3, 8, 1, 4, 6 };
                    X2Y2Values = new[] { 1, 3, 6, 5, 8, 2, 4, 7 };
                    X3Y2Values = new[] { 3, 7, 6, 2, 5, 4, 8, 1 };
                    X4Y2Values = new[] { 6, 2, 7, 8 };

                    X1Y3Values = new[] { 5, 6, 3, 8, 1, 4, 7, 2 };
                    X2Y3Values = new[] { 3, 2, 7, 8, 4, 1, 6, 5 };
                    X3Y3Values = new[] { 8, 3, 1, 5 };
                    X4Y3Values = new[] { 5, 3, 2, 6 };

                    break;
                case 7:
                    X1Y1Values = new[] { 7, 3, 5, 2, 8, 1, 6, 4 };
                    X2Y1Values = new[] { 7, 6, 5, 4 };
                    X3Y1Values = new[] { 4, 1, 5, 3, 8, 7, 2, 6 };
                    X4Y1Values = new[] { 8, 6, 4, 1 };

                    X1Y2Values = new[] { 1, 8, 6, 4, 5, 7, 3, 2 };
                    X2Y2Values = new[] { 4, 7, 8, 2, 6, 5, 1, 3 };
                    X3Y2Values = new[] { 8, 1, 5, 4, 6, 2, 3, 7 };
                    X4Y2Values = new[] { 8, 7, 2, 6 };

                    X1Y3Values = new[] { 1, 4, 7, 2, 5, 6, 3, 8 };
                    X2Y3Values = new[] { 7, 8, 3, 2, 6, 5, 4, 1 };
                    X3Y3Values = new[] { 6, 7, 2, 4 };
                    X4Y3Values = new[] { 4, 7, 8, 1 };

                    break;
                case 8:
                    X1Y1Values = new[] { 8, 1, 6, 4, 7, 3, 5, 2 };
                    X2Y1Values = new[] { 7, 6, 5, 4 };
                    X3Y1Values = new[] { 5, 3, 4, 1, 2, 6, 8, 7 };
                    X4Y1Values = new[] { 6, 8, 1, 4 };

                    X1Y2Values = new[] { 1, 8, 6, 4, 5, 7, 3, 2 };
                    X2Y2Values = new[] { 4, 7, 8, 2, 6, 5, 1, 3 };
                    X3Y2Values = new[] { 8, 1, 5, 4, 6, 2, 3, 7 };
                    X4Y2Values = new[] { 2, 6, 8, 7 };

                    X1Y3Values = new[] { 4, 1, 2, 7, 6, 5, 8, 3 };
                    X2Y3Values = new[] { 3, 2, 7, 8, 4, 1, 6, 5 };
                    X3Y3Values = new[] { 2, 4, 6, 7 };
                    X4Y3Values = new[] { 2, 6, 5, 3 };
                    break;
                default:
                    X1Y1Values = new[] { 1, 8, 4, 6, 3, 7, 2, 5 };
                    X2Y1Values = new[] { 8, 3, 2, 1 };
                    X3Y1Values = new[] { 2, 6, 8, 7, 5, 3, 4, 1 };
                    X4Y1Values = new[] { 1, 4, 6, 8 };

                    X1Y2Values = new[] { 5, 7, 3, 2, 1, 8, 6, 4 };
                    X2Y2Values = new[] { 8, 2, 4, 7, 1, 3, 6, 5 };
                    X3Y2Values = new[] { 5, 4, 8, 1, 3, 7, 6, 2 };
                    X4Y2Values = new[] { 2, 6, 8, 7 };

                    X1Y3Values = new[] { 4, 1, 2, 7, 6, 5, 8, 3 };
                    X2Y3Values = new[] { 3, 2, 7, 8, 4, 1, 6, 5 };
                    X3Y3Values = new[] { 2, 4, 6, 7 };
                    X4Y3Values = new[] { 5, 3, 2, 6 };

                    break;
            }
        }
    }
}