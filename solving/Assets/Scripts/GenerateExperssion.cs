using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateExperssion : MonoBehaviour
{
    public static int solution;
    public Text[] answers;
    void Start()
    {
            solution = 0;
            int a, b;
            if (Random.Range(0, 2) == 0)
            {
                switch (Random.Range(0, 4))
                {
                    case 0:
                        {
                            a = Random.Range(0, 101);
                            b = Random.Range(0, 100 - a + 1);
                            solution = a + b;
                            GetComponent<Text>().text = a + "+" + b + "=?";
                            break;
                        }
                    case 1:
                        {
                            a = Random.Range(0, 101);
                            b = Random.Range(0, a + 1);
                            solution = a - b;
                        GetComponent<Text>().text = a + "-" + b + "=?";
                        break;
                        }
                    case 2:
                        {
                            a = Random.Range(0, 11);
                            b = Random.Range(0, 11);
                            solution = a * b;
                        GetComponent<Text>().text = a + "x" + b + "=?";
                        break;
                        }
                    case 3:
                        {
                            b = Random.Range(1, 11);
                            a = Random.Range(0, 11);
                            a *=  b;
                            solution = a / b;
                        GetComponent<Text>().text = a + ":" + b + "=?";
                        break;
                        }
                } 
            }
            else
            {
                int c;
                switch (Random.Range(3, 4))
                {
                    case 0:
                        {
                            a = Random.Range(0, 101);
                            switch (Random.Range(0, 4))
                            {
                                case 0:
                                    {
                                        b = Random.Range(0, 100 - a + 1);
                                        c = Random.Range(0, 100 - a-b + 1);
                                        solution = a + b+c;
                                        GetComponent<Text>().text = a + "+" + b + "+" + c + "=?";
                                        break;
                                    }
                                case 1:
                                    {
                                        b = Random.Range(0, Mathf.Min(a + 1,100-a+1));
                                        c = Random.Range(0, a-b + 1);
                                        solution = a + b-c;
                                        GetComponent<Text>().text = a + "+" + b + "-" + c + "=?";
                                        break;
                                    }
                                case 2:
                                    {
                                        if(Random.Range(0,2)==0)
                                        {
                                            b = Random.Range(0, Mathf.Min(11, 100 - a + 1));
                                            if (b != 0)
                                                c = Random.Range(0, (100 - a) / b + 1);
                                            else
                                                c = Random.Range(0, Mathf.Min(11, 100 - a + 1));
                                            solution = a + b * c;
                                            GetComponent<Text>().text = a + "+(" + b + "x" + c + ")=?";
                                        }
                                        else
                                        {
                                            a = Random.Range(0, 11);
                                            b = Random.Range(0, 10-a+1);
                                            c = Random.Range(0, 11);
                                            solution = (a + b) * c;
                                            GetComponent<Text>().text = "("+a + "+" + b + ")x" + c + "=?";
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if(Random.Range(0,2)==0)
                                        {
                                            do
                                            {
                                                c = Random.Range(1, Mathf.Min(11, 100 - a));
                                                b = Random.Range(0, Mathf.Min(11, 100 * c - a * c - c));
                                                b *= c;
                                                solution = a + b / c;
                                            } while (solution > 100);
                                        GetComponent<Text>().text = a + "+(" + b + ":" + c + ")=?";
                                        }
                                        else
                                        {
                                            do
                                            {
                                                a = Random.Range(0, 101);
                                                b = Random.Range(0, 100-a + 1);
                                                c = Random.Range(1, 11);
                                                a -= a % c;
                                                b -= b % c;
                                                solution = (a + b) / c;
                                            } while (solution > 10);
                                        GetComponent<Text>().text = "(" + a + "+" + b + "):" + c + "=?";
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 1:
                        {
                            a = Random.Range(0, 101);
                            switch (Random.Range(0, 4))
                            {
                                case 0:
                                    {
                                        if(Random.Range(0,2)==0)
                                        {
                                            b = Random.Range(0, a + 1);
                                            c = Random.Range(0, a - b + 1);
                                            solution = a - (b + c);
                                        GetComponent<Text>().text = a + "-(" + b + "+" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(0, a + 1);
                                            c = Random.Range(0, 100-a+b+1);
                                            solution = a - b + c;
                                        GetComponent<Text>().text =  a + "-" + b + "+" + c + "=?";
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        b = Random.Range(0, a + 1);
                                        c = Random.Range(0, a - b + 1);
                                        solution = a - b - c;
                                    GetComponent<Text>().text = a + "-" + b + "-" + c + "=?";
                                        break;
                                    }
                                case 2:
                                    {
                                        if(Random.Range(0,2)==0)
                                        {
                                            do
                                            {
                                                b = Random.Range(0, Mathf.Min(11, a + 1));
                                                c = Random.Range(0, 11);
                                                solution = a - b * c;
                                            } while (solution > 100 || solution < 0);
                                        GetComponent<Text>().text = a + "-(" + b + "x" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(0, a + 1);

                                            if (a - b != 0)
                                                c = Random.Range(0, Mathf.Min(11,100/(a-b+1)+1));
                                            else
                                                c = Random.Range(0, 101);
                                            while (c!=0&&a - b > 10)
                                            {
                                                b -= b / c;
                                                a -= a / c;
                                            }   
                                            solution = (a - b) * c;
                                        GetComponent<Text>().text = "(" + a + "-" + b + ")x" + c + "=?";
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if(Random.Range(0,2)==0)
                                        {
                                            do
                                            {
                                                b = Random.Range(0, 101);
                                                c = Random.Range(1, 11);
                                                if (b != 0)
                                                {
                                                    b -= b % c;
                                                    while (b / c > 10)
                                                    {
                                                        int tmp = Random.Range(1, b / c);
                                                        b -= c * tmp;
                                                    }
                                                }
                                                solution = a - b / c;
                                            } while (solution > 100 || solution < 0);
                                        GetComponent<Text>().text = a + "-(" + b + ":" + c + ")=?";
                                        }
                                        else
                                        {
                                            do
                                            {
                                                b = Random.Range(0, a + 1);
                                                c = Random.Range(1, 11);
                                                a -= a % c;
                                                b -= b % c;
                                                solution = (a - b) / c;
                                            } while (solution > 10);
                                        GetComponent<Text>().text = "(" + a + "-" + b + "):" + c + "=?";
                                        }
                                    }
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            a = Random.Range(0, 11);
                            switch (Random.Range(0, 4))
                            {
                                case 0:
                                    {
                                        if (Random.Range(0, 2) == 0)
                                        {
                                            b = Random.Range(0, 11);
                                            c = Random.Range(0, 10-b+1);
                                            solution = a * (b + c);
                                        GetComponent<Text>().text = a + "x(" + b + "+" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(0, 11);
                                            c = Random.Range(0, 100 - a * b + 1);
                                            solution = a * b + c;
                                        GetComponent<Text>().text = a + "*" + b + "+" + c + "=?";
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        if(Random.Range(0,2)==1)
                                        {
                                            b = Random.Range(0, 101);
                                            do
                                            {
                                                c = Random.Range(0, b + 1);
                                            } while ( b-c > 10);

                                            solution = a * (b - c);
                                        GetComponent<Text>().text = a + "x(" + b + "-" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(0, 11);
                                            c = Random.Range(0, a*b + 1);
                                            solution = a * b - c;
                                        GetComponent<Text>().text = "(" + a + "x" + b + ")-" + c + "=?";
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        a = Random.Range(0, 6);
                                        do
                                        {
                                            b = Random.Range(0, 11);
                                        } while (a * b > 10);
                                        do
                                        {
                                            c = Random.Range(0, 11);
                                        } while (a * b*c > 100);
                                        solution = (a * b) * c;
                                    GetComponent<Text>().text = a + "*" + b + "*" + c + "=?";
                                        break;
                                    }
                                case 3:
                                    {
                                        if (Random.Range(0, 2) == 1)
                                        {
                                            c = Random.Range(1, 11);
                                            b = Random.Range(0, 11);
                                            b *= c;
                                            solution =a*( b / c);
                                        GetComponent<Text>().text =a + "x(" + b + ":" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(0, 11);
                                            c = Random.Range(1, 11);
                                            a -= a % c;
                                            b -= b % c;
                                            solution = (a * b) / c;
                                        GetComponent<Text>().text = "(" + a + "*" + b + "):" + c + "=?";
                                        }
                                    }
                                    break;
                            }
                            break;
                        }
                    case 3:
                        {
                            a = Random.Range(0, 11);
                            switch (Random.Range(0, 4))
                            {
                                case 0:
                                    {
                                        if (Random.Range(0, 2) == 0)
                                        {
                                            int tmp = Random.Range(1, 11);
                                            a *= tmp;
                                            b = Random.Range(0, tmp + 1);
                                            c = tmp - b;
                                            solution = a / (b + c);
                                        GetComponent<Text>().text = a + ":(" + b + "+" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(1, 11);
                                            a = Random.Range(0, 11);
                                            a *= b;
                                            c = Random.Range(0, a / b+1);
                                            solution = a / b + c;
                                        GetComponent<Text>().text = "(" + a + ":" + b + ")+" + c + "=?";
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        if (Random.Range(0, 2) == 1)
                                        {
                                            int tmp = Random.Range(1, 11);
                                            a *= tmp;
                                            c = Random.Range(0, tmp);
                                            b = tmp + c;
                                        GetComponent<Text>().text = a + ":(" + b + "-" + c + ")=?";
                                            solution = a / (b - c);  
                                        }
                                        else
                                        {
                                            b = Random.Range(1, 11);
                                            a = Random.Range(0, 11);
                                            a *= b;
                                            c = Random.Range(0, a / b + 1);
                                            solution = a / b - c;
                                        GetComponent<Text>().text = "(" + a + ":" + b + ")-" + c + "=?";
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        if (Random.Range(0, 2) == 0)
                                        {
                                            do
                                            {
                                                a = Random.Range(0, 11);
                                                int tmp = Random.Range(1, 11);
                                                a *= tmp;
                                                c = Random.Range(1, tmp);
                                                b = tmp / c;
                                                a -= a % (b * c);
                                                solution = a / (b * c);
                                            } while (solution > 10);
                                        GetComponent<Text>().text =a + ":(" + b + "x" + c + ")=?";
                                        }
                                        else
                                        {
                                            b = Random.Range(1, 11);
                                            a = Random.Range(0, 11);
                                            a *= b;
                                            c = Random.Range(0, 11);
                                            solution = (a / b) * c;
                                        GetComponent<Text>().text = "(" + a + ":" + b + ")x" + c + "=?";
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if (Random.Range(0, 2) == 0)
                                        {
                                            b = Random.Range(1, 11);
                                            a = Random.Range(0, 11);
                                            a *= b;
                                            do
                                            {
                                                c = Random.Range(1, 11);
                                                solution = (a / b) / c;
                                            } while ((a/b)%c!=0);
                                            solution = (a / b) / c;
                                        GetComponent<Text>().text = "(" + a + ":" + b + "):" + c + "=?";
                                        }
                                        else
                                        {
                                            int tmp = Random.Range(1, 11);
                                            a = Random.Range(0, 11);
                                            a *= tmp;
                                            do
                                            {
                                                c = Random.Range(1, 11);
                                                b = c * tmp;
                                                solution = (a / b) / c;
                                            } while (b>100);
                                            solution = a / (b / c);
                                        GetComponent<Text>().text = a + ":(" + b + ":" + c + ")=?";
                                        }
                                    }
                                    break;
                            }
                            break;
                        }
                }
            }
        answers[Random.Range(0, answers.Length)].text = solution.ToString();
        for(int i=0;i<answers.Length;++i)
        {
            if (answers[i].text != solution.ToString())
            {
                answers[i].text = "-1";
                int tmp;
                do
                {
                    tmp = Random.Range(Mathf.Max(0, solution - 10), Mathf.Min(100, solution + 10));
                } while (check(tmp));
                answers[i].text = tmp.ToString();
            }
        }
    }

    bool check(int t)
    {
        for (int i = 0; i < answers.Length; ++i)
            if (answers[i].text == t.ToString())
                return true;
        return false;
    }
}
