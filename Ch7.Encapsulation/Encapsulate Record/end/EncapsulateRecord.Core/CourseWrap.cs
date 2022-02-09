using System.Linq;

namespace EncapsulateRecord.Core
{
    public class CourseWrap
    {
        private readonly Course _data;

        public Course Data => new(_data);

        public CourseWrap(Course data)
        {
            _data = data;
        }

        public void SetPerformanceScore(string courseId, string teacherId,
            string performanceName, int performanceScore)
        {
            _data[courseId].Teachers[teacherId][performanceName] = performanceScore;
        }

        public int GetTotalPerformanceScore(string courseId, string teacherId)
        {
            return _data[courseId].Teachers[teacherId].Sum(performance => performance.Value);
        }
    }
}