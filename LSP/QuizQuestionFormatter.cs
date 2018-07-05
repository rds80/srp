using System;

namespace srp.LSP
{
    public class QuizQuestionFormatter
    {
        public string Format(QuizQuestion quizQuestion)
        {
            return $"{quizQuestion.Question}{Environment.NewLine}" +
                $"{quizQuestion.Answer1}{Environment.NewLine}" +
                $"{quizQuestion.Answer2}{Environment.NewLine}" +
                $"{quizQuestion.Answer3}{Environment.NewLine}" +
                $"{quizQuestion.Answer4}{Environment.NewLine}";
        }
    }
}