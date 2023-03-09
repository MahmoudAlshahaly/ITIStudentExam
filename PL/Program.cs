using BLL.Interfaces;
using BLL.Repository;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace PL
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<DBHelper>();
            services.AddScoped<IStudentAnswerRepository, StudentAnswerRepository>();
            services.AddScoped<IStudentGradeRepository, StudentGradeRepository>();
            services.AddScoped<IExamGetRepository, ExamGetRepository>();
            services.AddScoped<IInstructorCourseRepository, InstructorCourseRepository>();
            services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IInstructorRepository, InstructorRepository>();
            ServiceProvider = services.BuildServiceProvider();

        }
        public static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new FrmLogin());
        }
    }
}
