using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;
    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        set
        {
            if (this.problemsSolved < 0)
            {
                this.problemsSolved = 0;
            }
            else if (problemsSolved > 10)
            {
                problemsSolved = 10;
            }
            else
            { 
                this.problemsSolved = value;
            }
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}
