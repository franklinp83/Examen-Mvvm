//using AndroidX.Lifecycle;
using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class Examen_MvvmView : ContentView
{
	Examen_MvvmViewModels viewModel;
	public Examen_MvvmView()
	{
		InitializeComponent();
        viewModel = new Examen_MvvmViewModels();
        BindingContext = viewModel;
    }
}