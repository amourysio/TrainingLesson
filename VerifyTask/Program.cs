using System;

namespace VerifyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainingLesson trainingLesson = new TrainingLesson(new Guid(), "txt");
            trainingLesson.AddTrainingMaterial(new TextMaterial(new Guid(), "Here is ...", "Materials")); ;
            trainingLesson.AddTrainingMaterial(new VideoMaterial(new Guid(), "Lection","asddsa","dsaads",VideoFormatType.Avi));

            Type typeInfo = trainingLesson.GetType(); // reflection
            var detailedInfo = typeInfo.GetMethods();
            TrainingLesson trainingLessonCopy = (TrainingLesson) trainingLesson.Clone();
        }
    }
}
