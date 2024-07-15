using MVC.Models;

namespace MVC.ViewModels
{
    public class HomeVM
    {
        public string GroupName {  get; set; }
        public Student Student { get; set; }
        public List<Student> Students { get; set; }
    }
}
