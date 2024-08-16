using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{

    internal class BnB
    {
        public Dictionary<int, double[,]> FindOptmal()
        {
            PrimalSimplex primalSimplex = new PrimalSimplex();
            mainForm form = new mainForm();

            int pivitCol = -1;
            int pivitRow = -1;
            int varAmount = 6;
            double dec = 0;
            int lastCol;
            int lastRow;
            int optimalName = 0;
            int unoptimalName = 0;
            bool infeasable = false;

            Dictionary<int, double[,]> optimalTables = new Dictionary<int, double[,]>();
            Dictionary<int, double[,]> unoptimalTables = new Dictionary<int, double[,]>();

            // Declare and initialize a 2D list (list of lists of doubles)
            List<List<double>> slackT = new List<List<double>>
        {
            new List<double> {0.2, 0, 0, 0, 0, 0, 0.2, 0, 1.4, 1.8, 2.2, 0, 2, 15.4},
            new List<double> {1.1, 0, 0, 0, 1, 0, 0.1, 0, -0.8, -0.6, -1.4, 0, -1, 0.2},
            new List<double> {1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
            new List<double> {0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
            new List<double> {0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
            new List<double> {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
            new List<double> {-1.1, 0, 0, 0, 0, 0, -0.1, 0, 0.8, 0.6, 1.4, 1, 1, 0.8},
            new List<double> {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1}
        };
            List<double> slackRHS = new List<double>(Slack.findRHS(slackT));

            TwoPhase twoPhase = new TwoPhase();
            ListTracker listTracker = new ListTracker();
            Excess excess = new Excess();
            Slack slack = new Slack();


            if (Slack.findingDec(slackRHS) == -1)
            {
            }
            else
            {
                dec = Slack.findingDec(slackRHS);
                lastCol = slackT[0].Count - 1;
                pivitRow = Slack.findPivitRow(slackT, lastCol, varAmount);
                pivitCol = Slack.findPivitCol(slackT, pivitRow, varAmount);

                slackT = Slack.addingSlackConstraint(slackT, slackRHS, pivitCol, dec, lastCol);

                lastRow = slackT.Count - 1;
                lastCol = slackT[0].Count - 1;
                slackT = Slack.simplifyConstraintSlack(slackT, pivitCol, lastRow, lastCol);

                lastCol = slackT[0].Count - 1;
                lastRow = slackT.Count - 1;

                if (Slack.ratioCheck(slackT, lastRow) == -1)
                {
                }
                else
                {
                    pivitCol = Slack.ratioCheck(slackT, lastRow);
                }
                slackRHS = Slack.findRHS(slackT);
                infeasable = false;

                while ((twoPhase.optimalityCheck(slackRHS) == false) && (infeasable == false))
                {

                    slackRHS = twoPhase.findRHS(slackT);
                    pivitRow = twoPhase.findPivitRow(slackRHS, slackT);
                    if (pivitRow == -1)
                    {
                        infeasable = true;
                    }
                    else
                    {
                        pivitCol = twoPhase.findPivitCol(slackT, pivitRow);
                        slackT = twoPhase.twoPhaseMath(slackT, pivitRow, pivitCol);
                        lastCol = slackT[0].Count - 1;
                        slackRHS = twoPhase.findRHS(slackT);
                    }
                };

                lastRow = slackT.Count;
                lastCol = slackT[0].Count;

                slackT = RoundValues(slackT);

                double[,] slackArray = listTracker.toArray(slackT, lastRow, lastCol);
                slackRHS = twoPhase.findRHS(slackT);

                if (Slack.optimalityCheck(slackRHS) == true)
                {
                    optimalName++;
                    optimalTables.Add(optimalName, slackArray);
                }
                else
                {
                    unoptimalName++;
                    unoptimalTables.Add(unoptimalName, slackArray);
                }
            }

            //excess starts
            List<List<double>> excessT = new List<List<double>>
        {
            new List<double> {0.2, 0, 0, 0, 0, 0, 0.2, 0, 1.4, 1.8, 2.2, 0, 2, 15.4},
            new List<double> {1.1, 0, 0, 0, 1, 0, 0.1, 0, -0.8, -0.6, -1.4, 0, -1, 0.2},
            new List<double> {1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
            new List<double> {0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
            new List<double> {0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
            new List<double> {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
            new List<double> {-1.1, 0, 0, 0, 0, 0, -0.1, 0, 0.8, 0.6, 1.4, 1, 1, 0.8},
            new List<double> {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1}
        };
            List<double> excessRHS = new List<double>(Excess.findRHS(excessT));

            if (Excess.findingDec(excessRHS) == -1)
            {
            }
            else
            {
                dec = Excess.findingDec(excessRHS);
                lastCol = excessT[0].Count - 1;
                pivitRow = Excess.findPivitRow(excessT, lastCol, varAmount);
                pivitCol = Excess.findPivitCol(excessT, pivitRow, varAmount);

                excessT = Excess.addingExcessConstraint(excessT, excessRHS, pivitCol, dec, lastCol);

                lastRow = excessT.Count - 1;
                lastCol = excessT[0].Count - 1;
                excessT = Excess.simplifyConstraintExcess(excessT, pivitCol, lastRow, lastCol);

                lastCol = excessT[0].Count - 1;
                lastRow = excessT.Count - 1;

                if (Excess.ratioCheck(excessT, lastRow) == -1)
                {
                }
                else
                {
                    pivitCol = Excess.ratioCheck(excessT, lastRow);
                }

                excessRHS = Excess.findRHS(excessT);
                infeasable = false;

                while ((twoPhase.optimalityCheck(excessRHS) == false) && (infeasable == false))
                {
                    excessRHS = twoPhase.findRHS(excessT);
                    pivitRow = twoPhase.findPivitRow(excessRHS, excessT);
                    if (pivitRow == -1)
                    {
                        infeasable = true;
                    }
                    else
                    {
                        pivitCol = twoPhase.findPivitCol(excessT, pivitRow);
                        excessT = twoPhase.twoPhaseMath(excessT, pivitRow, pivitCol);
                        lastCol = excessT[0].Count - 1;
                        excessRHS = twoPhase.findRHS(excessT);
                    }

                };

                lastRow = excessT.Count;
                lastCol = excessT[0].Count;

                excessT = RoundValues(excessT);

                double[,] excessArray = listTracker.toArray(excessT, lastRow, lastCol);
                excessRHS = twoPhase.findRHS(excessT);

                if (Excess.optimalityCheck(excessRHS) == true)
                {
                    optimalName++;
                    optimalTables.Add(optimalName, excessArray);
                }
                else
                {
                    unoptimalName++;
                    unoptimalTables.Add(unoptimalName, excessArray);
                }
            }
            int count = 0;
            //Working on the branches
            while ((unoptimalTables.Count != 0) && (count < 15))
            {
                count++;
                List<List<double>> tempslackT = listTracker.Convert2DArrayToList(unoptimalTables[1]);//new instacne of slackT
                List<List<double>> tempexcessT = listTracker.Convert2DArrayToList(unoptimalTables[1]);//new instacne of excessT

                unoptimalTables.Remove(1);

                Dictionary<int, double[,]> tempDictionary = new Dictionary<int, double[,]>();

                int newKey = 1;

                foreach (var kvp in unoptimalTables)
                {
                    tempDictionary.Add(newKey, kvp.Value);
                    newKey++;
                }
                unoptimalTables.Clear();

                newKey = 1;
                foreach (var kvp in tempDictionary)
                {
                    unoptimalTables.Add(newKey, kvp.Value);
                    newKey++;
                }

                slackRHS = Slack.findRHS(tempslackT);

                if (Slack.findingDec(slackRHS) == -1)
                {
                }
                else
                {
                    dec = Slack.findingDec(slackRHS);
                    lastCol = tempslackT[0].Count - 1;
                    pivitRow = Slack.findPivitRow(tempslackT, lastCol, varAmount);

                    if (pivitRow == -1)
                    {
                    }
                    else
                    {
                        pivitCol = Slack.findPivitCol(tempslackT, pivitRow, varAmount);

                        if (pivitCol == -1)
                        {
                        }
                        else
                        {
                            tempslackT = Slack.addingSlackConstraint(tempslackT, slackRHS, pivitCol, dec, lastCol);

                            lastRow = tempslackT.Count - 1;
                            lastCol = tempslackT[0].Count - 1;
                            tempslackT = Slack.simplifyConstraintSlack(tempslackT, pivitCol, lastRow, lastCol);

                            lastCol = tempslackT[0].Count - 1;
                            lastRow = tempslackT.Count - 1;

                            if (Slack.ratioCheck(tempslackT, lastRow) == -1)
                            {
                            }
                            else
                            {
                                pivitCol = Slack.ratioCheck(tempslackT, lastRow);
                            }
                            slackRHS = Slack.findRHS(tempslackT);
                            infeasable = false;
                            tempslackT = RoundValues(tempslackT);

                            while ((twoPhase.optimalityCheck(slackRHS) == false) && (infeasable == false))
                            {
                                slackRHS = twoPhase.findRHS(tempslackT);
                                pivitRow = twoPhase.findPivitRow(slackRHS, tempslackT);
                                if (pivitRow == -1)
                                {
                                    infeasable = true;
                                }
                                else
                                {
                                    pivitCol = twoPhase.findPivitCol(tempslackT, pivitRow);
                                    tempslackT = twoPhase.twoPhaseMath(tempslackT, pivitRow, pivitCol);
                                    lastCol = tempslackT[0].Count - 1;
                                    slackRHS = twoPhase.findRHS(tempslackT);
                                }
                            };

                            if (infeasable == false)
                            {
                                lastRow = tempslackT.Count;
                                lastCol = tempslackT[0].Count;

                                tempslackT = RoundValues(tempslackT);

                                double[,] slackTempArray = listTracker.toArray(tempslackT, lastRow, lastCol);
                                slackRHS = twoPhase.findRHS(tempslackT);

                                if (Slack.optimalityCheck(slackRHS) == true)
                                {
                                    optimalName++;
                                    optimalTables.Add(optimalName, slackTempArray);
                                }
                                else
                                {
                                    unoptimalName++;
                                    unoptimalTables.Add(unoptimalName, slackTempArray);
                                }
                            }
                        }
                    }
                }

                //excess starts

                excessRHS = Excess.findRHS(tempexcessT);

                if (Excess.findingDec(excessRHS) == -1)
                {
                }
                else
                {
                    dec = Excess.findingDec(excessRHS);
                    lastCol = tempexcessT[0].Count - 1;
                    pivitRow = Excess.findPivitRow(tempexcessT, lastCol, varAmount);
                    if (pivitRow == -1)
                    {
                    }
                    else
                    {
                        pivitCol = Excess.findPivitCol(tempexcessT, pivitRow, varAmount);

                        if (pivitCol == -1)
                        {

                        }
                        else
                        {
                            tempexcessT = Excess.addingExcessConstraint(tempexcessT, excessRHS, pivitCol, dec, lastCol);

                            lastRow = tempexcessT.Count - 1;
                            lastCol = tempexcessT[0].Count - 1;
                            tempexcessT = Excess.simplifyConstraintExcess(tempexcessT, pivitCol, lastRow, lastCol);

                            lastCol = tempexcessT[0].Count - 1;
                            lastRow = tempexcessT.Count - 1;

                            if (Excess.ratioCheck(tempexcessT, lastRow) == -1)
                            {
                            }
                            else
                            {
                                pivitCol = Excess.ratioCheck(tempexcessT, lastRow);
                            }
                            excessRHS = Excess.findRHS(tempexcessT);
                            infeasable = false;
                            tempexcessT = RoundValues(tempexcessT);

                            while ((twoPhase.optimalityCheck(excessRHS) == false) && (infeasable == false))
                            {
                                excessRHS = twoPhase.findRHS(tempexcessT);
                                pivitRow = twoPhase.findPivitRow(excessRHS, tempexcessT);
                                if (pivitRow == -1)
                                {
                                    infeasable = true;
                                }
                                else
                                {
                                    pivitCol = twoPhase.findPivitCol(tempexcessT, pivitRow);
                                    tempexcessT = twoPhase.twoPhaseMath(tempexcessT, pivitRow, pivitCol);
                                    lastCol = tempexcessT[0].Count - 1;
                                    excessRHS = twoPhase.findRHS(tempexcessT);
                                }
                            };

                            if (infeasable == false)
                            {
                                lastRow = tempexcessT.Count;
                                lastCol = tempexcessT[0].Count;

                                tempexcessT = RoundValues(tempexcessT);

                                double[,] excessTempArray = listTracker.toArray(tempexcessT, lastRow, lastCol);
                                excessRHS = twoPhase.findRHS(tempexcessT);

                                if (Excess.optimalityCheck(excessRHS) == true)
                                {
                                    optimalName++;
                                    optimalTables.Add(optimalName, excessTempArray);
                                }
                                else
                                {
                                    unoptimalName++;
                                    unoptimalTables.Add(unoptimalName, excessTempArray);
                                }
                            }
                        }
                    }
                }
            }

            return optimalTables;

        }

        public static List<List<double>> RoundValues(List<List<double>> list)
        {
            return list.Select(innerList =>
                innerList.Select(value => Math.Round(value, 5)).ToList()
            ).ToList();
        }
    }
}
