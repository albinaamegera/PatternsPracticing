using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PatternsPracticing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , IView
    {
        AppPresenter _presenter;
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponents();
        }

        string IView.ClassValue { get => classTB.Text; set => comboBox.Text = value; }
        string IView.TypeValue { get => typeTB.Text; set => typeTB.Text = value; }
        string IView.NameValue { get => nameTB.Text; set => nameTB.Text = value; }
        string IView.AgeValue { get => ageTB.Text; set => ageTB.Text = value; }
        string IView.SaveMode { get => saveMode.Text; set => saveMode.Text = value; }
        IAnimal IView.Current 
        {
            get => null;
            set 
            {
                cardClass.Text = value.Class;
                cardType.Text = value.Type;
                cardName.Text = value.Name;
                cardAge.Text = value.Age;
            }
        }
        public void ClearView()
        {
            cardClass.Text = "";
            cardType.Text = "";
            cardName.Text = "";
            cardAge.Text = "";
        }
        private void InitializeComponents()
        {
            comboBox.ItemsSource = new string[] { "Mammal", "Bird", "Amphibian", "New class" };
            comboBox.SelectedIndex = 0;
            comboBox.DropDownClosed += (s, e) =>
            {
                if (comboBox.SelectedIndex == 3) classPanel.Visibility = Visibility.Visible;
                else classPanel.Visibility = Visibility.Collapsed;
                classTB.Text = comboBox.Text;
            };
            classTB.Text = comboBox.Text;

            saveMode.ItemsSource = new string[] { "json", "pdf", "txt" };
            saveMode.SelectedIndex = 0;

            _presenter = new(this);

            confirmBtn.Click += (s, e) => _presenter.NewAnimal();
            prevBtn.Click += (s, e) => _presenter.GetPreviousAnimal();
            nextBtn.Click += (s, e) => _presenter.GetNextAnimal();
            editBtn.Click += (s, e) => _presenter.EditAnimal();
            deleteBtn.Click += (s, e) => _presenter.DeleteAnimal();
            saveBtn.Click += (s, e) => _presenter.Save();
        }
    }
}