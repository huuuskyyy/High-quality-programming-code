using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;
    public int Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (this.grade < 0)
            {
                throw new ArgumentOutOfRangeException("Grade must be positive");
            }
            this.grade = value;
        }
    }
    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        set
        {
            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum grade must be positive");
            }

            this.minGrade = value;
        }
    }
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        set
        {
            if (maxGrade <= minGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade must be greater than minimum grade");
            }

            this.maxGrade = value;
        }
    }
    public string Comments
    {
        get
        {
            return this.comments;
        }
        set
        {
            if (comments == null || comments == "")
            {
                throw new ArgumentNullException("The comment is empty. Must enter comment");
            }

            this.comments = value;
        }
    }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
