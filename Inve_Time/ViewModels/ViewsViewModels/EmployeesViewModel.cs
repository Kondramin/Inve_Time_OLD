using Inve_Time.Entities.Entities;
using Inve_Time.Interfaces.Repositories;
using Inve_Time.Interfaces.Services;
using Inve_Time.ViewModels.Base;

namespace Inve_Time.ViewModels.ViewsViewModels
{
    class EmployeesViewModel : ViewModel
    {
        private readonly IRepository<Employee> _EmployeeRepository;
        private readonly IUserDialog _UserDialog;


        public EmployeesViewModel(
            IRepository<Employee> employeeRepository,
            IUserDialog userDialog
            )
        {
            _EmployeeRepository = employeeRepository;
            _UserDialog = userDialog;
        }


        //#region ObservableCollection<EmpBaseInfo> EmployeesCollection - collection of employees 

        //private ObservableCollection<EmployeeModel> _EmployeesCollection;
        ///// <summary>EmployeesCollection - collection of employees</summary>
        //public ObservableCollection<EmployeeModel> EmployeesCollection
        //{
        //    get => _EmployeesCollection;
        //    set
        //    {
        //        if (Set(ref _EmployeesCollection, value))
        //        {
        //            _EmployeesViewSource = new CollectionViewSource
        //            {
        //                Source = value,
        //                SortDescriptions =
        //                {
        //                    new SortDescription(nameof(EmployeeModel.Fio), ListSortDirection.Ascending)
        //                }

        //            };

        //            _EmployeesViewSource.Filter += OnAnyFilter;
        //            _EmployeesViewSource.Filter += OnFIOFilter;
        //            _EmployeesViewSource.Filter += OnPhoneFilter;
        //            _EmployeesViewSource.Filter += OnEmailFilter;
        //            _EmployeesViewSource.Filter += OnPositionNameFilter;

        //            _EmployeesViewSource.View.Refresh();

        //            OnPropertyChanged(nameof(EmployeesView));

        //        }
        //    }
        //}

        //#endregion


        ///// <summary>CollectoinViewSource of EmpBaseInfo</summary>
        //private CollectionViewSource _EmployeesViewSource;


        ///// <summary>ICollection of EmpBaseInfo. Using to show in DataGrid</summary>
        //public ICollectionView EmployeesView => _EmployeesViewSource?.View;


        //#region EmployeeBaseInfo SelectedEmployee

        //private EmployeeModel _SelectedEmployee;
        ///// <summary>SelectedEmployee in DataGrid</summary>
        //public EmployeeModel SelectedEmployee
        //{
        //    get => _SelectedEmployee;
        //    set => Set(ref _SelectedEmployee, value);
        //}

        //#endregion



        //#region About Filters


        //private void OnAnyFilter(object sender, FilterEventArgs e)
        //{
        //    if (e.Item is not EmployeeModel empBaseInfo || string.IsNullOrEmpty(FilterAnyWord)) return;

        //    if (empBaseInfo.Any == null || !empBaseInfo.Any.ToLower().Contains(FilterAnyWord.ToLower()))
        //        e.Accepted = false;
        //}

        //private void OnFIOFilter(object sender, FilterEventArgs e)
        //{
        //    if (e.Item is not EmployeeModel empBaseInfo || string.IsNullOrEmpty(FilterFIOWord)) return;

        //    if (empBaseInfo.Fio == null || !empBaseInfo.Fio.ToLower().Contains(FilterFIOWord.ToLower()))
        //        e.Accepted = false;
        //}

        //private void OnPhoneFilter(object sender, FilterEventArgs e)
        //{
        //    if (e.Item is not EmployeeModel empBaseInfo || string.IsNullOrEmpty(ConvertedFilterPhoneField())) return;

        //    if (empBaseInfo.Phone == null || !empBaseInfo.Phone.Contains(ConvertedFilterPhoneField()))
        //        e.Accepted = false;
        //}

        //private void OnEmailFilter(object sender, FilterEventArgs e)
        //{
        //    if (e.Item is not EmployeeModel empBaseInfo || string.IsNullOrEmpty(FilterEmailWord)) return;

        //    if (empBaseInfo.Email == null || !empBaseInfo.Email.ToLower().Contains(FilterEmailWord.ToLower()))
        //    {
        //        e.Accepted = false;
        //    }
        //}

        //private void OnPositionNameFilter(object sender, FilterEventArgs e)
        //{
        //    if (e.Item is not EmployeeModel empBaseInfo || string.IsNullOrEmpty(FilterPositionWord)) return;

        //    if ((empBaseInfo.Position == null) || (!empBaseInfo.Position.Name.ToLower().Contains(FilterPositionWord.ToLower())))
        //        e.Accepted = false;
        //}



        //#region Filter Fields


        //#region string EmployeeView FilterAny 

        //private string _FilterAnyWord;
        ///// <summary>EmployeeView FilterAny - searching word</summary>
        //public string FilterAnyWord
        //{
        //    get => _FilterAnyWord;
        //    set
        //    {
        //        if (Set(ref _FilterAnyWord, value))
        //            _EmployeesViewSource.View.Refresh();
        //    }
        //}

        //#endregion

        //#region string EmployeeView FilterFIO 

        //private string _FilterFIOWord;
        ///// <summary>EmployeeView FilterFIO - searching word</summary>
        //public string FilterFIOWord
        //{
        //    get => _FilterFIOWord;
        //    set
        //    {
        //        if (Set(ref _FilterFIOWord, value))
        //            _EmployeesViewSource.View.Refresh();
        //    }
        //}

        //#endregion

        //#region string EmployeeView FilterPhone 

        //private string _FilterPhoneWord;
        ///// <summary>EmployeeView FilterPhone - searching word</summary>
        //public string FilterPhoneWord
        //{
        //    get => _FilterPhoneWord;
        //    set
        //    {
        //        if (Set(ref _FilterPhoneWord, value))
        //            _EmployeesViewSource.View.Refresh();
        //    }
        //}

        //#endregion

        //#region string EmployeeView FilterEmail 

        //private string _FilterEmailWord;
        ///// <summary>EmployeeView FilterEmail - searching word</summary>
        //public string FilterEmailWord
        //{
        //    get => _FilterEmailWord;
        //    set
        //    {
        //        if (Set(ref _FilterEmailWord, value))
        //            _EmployeesViewSource.View.Refresh();
        //    }
        //}

        //#endregion

        //#region string EmployeeView FilterPosition 

        //private string _FilterPositionWord;
        ///// <summary>EmployeeView FilterPosition - searching word</summary>
        //public string FilterPositionWord
        //{
        //    get => _FilterPositionWord;
        //    set
        //    {
        //        if (Set(ref _FilterPositionWord, value))
        //            _EmployeesViewSource.View.Refresh();
        //    }
        //}

        //#endregion


        //#endregion



        //private string ConvertedFilterPhoneField()
        //{
        //    if (FilterPhoneWord is null) return null;

        //    var phone = FilterPhoneWord.Remove(0, 5);

        //    int fRemStart = 0;
        //    int fRemTrim = 0;


        //    for (int i = 0; i < phone.Length; i++)
        //    {
        //        if (!(phone[i] >= '0' && phone[i] <= '9'))
        //        {
        //            fRemTrim++;
        //        }
        //        else break;
        //    }

        //    if (fRemTrim == phone.Length) return null;


        //    phone = phone.Remove(fRemStart, fRemTrim);

        //    int sRemStart = phone.Length;
        //    int sRemTrim = 0;

        //    for (int j = phone.Length; j > 0; j--)
        //    {
        //        if (!(phone[j - 1] >= '0' && phone[j - 1] <= '9'))
        //        {
        //            sRemStart--;
        //            sRemTrim++;
        //        }
        //    }

        //    phone = phone.Remove(sRemStart, sRemTrim);

        //    return phone;
        //}



        //#endregion



        //#region Commands



        //#region Command LoadEmployeesCommand - Load Employees from database

        ///// <summary>Load Employees from database</summary>
        //private ICommand _LoadEmployeesCommand;

        ///// <summary>Load Employees from database</summary>
        //public ICommand LoadEmployeesCommand => _LoadEmployeesCommand
        //    ??= new LambdaCommandAsync(OnLoadEmployeesCommandExequted);

        ///// <summary>Execution logic - Load Employees from database</summary>
        //public async Task OnLoadEmployeesCommandExequted(object p)
        //{
        //    EmployeesCollection = new ObservableCollection<EmployeeModel>(await _EmployeeRepository.Items
        //    .Select(e => new EmployeeModel
        //    {
        //        Id = e.Id,
        //        Name = e.Name,
        //        SecondName = e.SecondName,
        //        Patronymic = e.Patronymic,
        //        Phone = e.Phone,
        //        Email = e.Email,
        //        Position = e.Position
        //    })
        //    .OrderBy(p => p.SecondName)
        //    .ThenBy(p => p.Name)
        //    .ThenBy(p => p.Patronymic)
        //    .ToArrayAsync());
        //}

        //#endregion


        //#region Command CleanFilterFieldsCommand - Clean filter fields

        ///// <summary>Clean filter fields</summary>
        //private ICommand _CleanFilterFieldsCommand;

        ///// <summary>Clean filter fields</summary>
        //public ICommand CleanFilterFieldsCommand => _CleanFilterFieldsCommand
        //    ??= new LambdaCommand(OnCleanFilterFieldsCommandExequted);

        ///// <summary>Execution logic - Clean filter fields</summary>
        //public void OnCleanFilterFieldsCommandExequted(object p)
        //{
        //    FilterAnyWord = null;
        //    FilterFIOWord = null;
        //    FilterPhoneWord = null;
        //    FilterEmailWord = null;
        //    FilterPositionWord = null;
        //}

        //#endregion


        //#region Command AddNewEmployeeCommand - Add new employee

        ///// <summary>Add new employee</summary>
        //private ICommand _AddNewEmployeeCommand;

        ///// <summary>Add new employee</summary>
        //public ICommand AddNewEmployeeCommand => _AddNewEmployeeCommand
        //    ??= new LambdaCommand(OnAddNewEmployeeCommandExequted, CanAddNewEmployeeCommandExequt);

        ///// <summary>Checking the possibility of execution - Add new employee</summary>
        //public bool CanAddNewEmployeeCommandExequt(object p) => MainWindowViewModel.AutorisatedEmployee.Position.AccessLevel > 3;

        ///// <summary>Execution logic - Add new employee</summary>
        //public void OnAddNewEmployeeCommandExequted(object p)
        //{
        //    var new_employee = new Employee();

        //    if (!_UserDialog.EditEpmloyee(new_employee)) return;

        //    var empBase = new EmployeeBaseInfo(_EmployeeRepository.Add(new_employee));

        //    _EmployeesCollection.Add(empBase);

        //    SelectedEmployee = empBase;
        //}

        //#endregion


        //#region Command ModifiEmployeeCommand - Modifi employee

        ///// <summary>Modifi employee</summary>
        //private ICommand _ModifiEmployeeCommand;

        ///// <summary>Modifi employee</summary>
        //public ICommand ModifiEmployeeCommand => _ModifiEmployeeCommand
        //    ??= new LambdaCommand(OnModifiEmployeeCommandExequted, CanModifiEmployeeCommandExequt);

        ///// <summary>Checking the possibility of execution - Modifi employee</summary>
        //public bool CanModifiEmployeeCommandExequt(object p) => MainWindowViewModel.AutorisatedEmployee.Position.AccessLevel > 5;

        ///// <summary>Execution logic - Modifi employee</summary>
        //public void OnModifiEmployeeCommandExequted(object p)
        //{
        //    var emp_to_modifi = p ?? SelectedEmployee;

        //    if (emp_to_modifi is not EmployeeModel empBase) return;

        //    var employee = _EmployeeRepository.Get(empBase.Id);

        //    if (!_UserDialog.EditEpmloyee(employee)) return;

        //    _EmployeeRepository.Update(employee);

        //    EmployeesCollection.Remove(empBase);

        //    var newEmployeeBaseInfo = new EmployeeBaseInfo(employee);

        //    EmployeesCollection.Add(newEmployeeBaseInfo);

        //    SelectedEmployee = newEmployeeBaseInfo;
        //}

        //#endregion


        //#region Command RemoveEmployeeCommand - Remove employee

        ///// <summary>Remove employee</summary>
        //private ICommand _RemoveEmployeeCommand;

        ///// <summary>Remove employee</summary>
        //public ICommand RemoveEmployeeCommand => _RemoveEmployeeCommand
        //    ??= new LambdaCommand(OnRemoveEmployeeCommandExequted, CanRemoveEmployeeCommandExequt);

        ///// <summary>Checking the possibility of execution - Remove employee</summary>
        //public bool CanRemoveEmployeeCommandExequt(object p) => MainWindowViewModel.AutorisatedEmployee.Position.AccessLevel > 7;

        ///// <summary>Execution logic - Remove employee</summary>
        //public void OnRemoveEmployeeCommandExequted(object p)
        //{
        //    var emp_to_remove = p ?? SelectedEmployee;

        //    if (emp_to_remove is not EmployeeModel empBase) return;


        //    if (!_UserDialog.ConfirmInformation($"Вы уверены, что хотите удалить сотрудника {empBase.Fio}?", "Удаление сотрудника")) return;


        //    _EmployeeRepository.Remove(empBase.Id);

        //    _EmployeesCollection.Remove(empBase);
        //    if (ReferenceEquals(SelectedEmployee, empBase)) SelectedEmployee = null;
        //}

        //#endregion



        //#endregion

    }
}
