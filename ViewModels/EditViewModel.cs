namespace TP2.ViewModels
{
    public class EditViewModel : CreateViewModel
    {

        public new int Id { get; set; }
        public required string ExistingImagePath { get; set; }
    }
}
