using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternsPracticing
{
    internal class AppPresenter
    {
        IView _view;
        SaverManager _saverManager;
        List<IAnimal> _animals;
        int _currentIndex;

        public AppPresenter(IView view)
        {
            _view = view;
            _saverManager = new();
            _animals = _saverManager.Load();
        }
        public void NewAnimal()
        {
            try
            {
                _animals.Add(AnimalFactory.GetAnimal(_view.ClassValue, _view.TypeValue, _view.NameValue, _view.AgeValue));
                _view.Current = _animals.Last();
                _currentIndex = _animals.IndexOf(_animals.Last());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void GetPreviousAnimal()
        {
            if (_currentIndex - 1 < 0) return;
            _view.Current = _animals[--_currentIndex];
        }
        public void GetNextAnimal()
        {
            if (_currentIndex + 1 >= _animals.Count) return;
            _view.Current = _animals[++_currentIndex];
        }
        public void EditAnimal()
        {
            if (_animals.Count == 0) return;
            _animals[_currentIndex].Edit(_view.ClassValue, _view.TypeValue, _view.NameValue, _view.AgeValue);
            _view.Current = _animals[_currentIndex];
        }
        public void DeleteAnimal()
        {
            if (_animals.Count - 1 > 0)
            {
                _animals.RemoveAt(_currentIndex);
                _currentIndex = _animals.IndexOf(_animals.Last());
                _view.Current = _animals[_currentIndex];
                return;
            }
            _currentIndex = 0;
            _animals.Clear();
            _view.ClearView();
        }
        public void Save()
        {
            _saverManager.SetMode(_view.SaveMode);
            _saverManager.Save();
        }
    }
}
