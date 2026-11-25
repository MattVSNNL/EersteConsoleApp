using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Opdracht_11;

internal class RekenQuiz
{

    private float _num1;
    private float _num2;
    private string _op;

    public RekenQuiz(float num1, float num2, string op)
    {
        _num1 = num1;
        _num2 = num2;
        _op = op;
    }

    public questionStructure GenerateQuestion() => new questionStructure(_num1, _num2, _op);
    public bool CheckAnswer(float sentAnswer)
    {
        float answer;

        switch(_op)
        {
            case "+":
                answer = _num1 + _num2;
                break;
            case "-":
                answer = _num1 - _num2;
                break;
            case "*":
                answer = _num1 * _num2;
                break;
            case "/":
                if (_num2 == 0)
                {
                    throw new InvalidOperationException("Can't divide by zero");
                }
                answer = (float)Math.Round(_num1 / _num2, 2); // , 2 for two digits
                break;
            default:
                throw new InvalidOperationException("Unknown Operator");
        }

        if (answer != sentAnswer)
            return false;

        return true;
    }
}
