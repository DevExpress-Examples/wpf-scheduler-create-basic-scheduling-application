<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655772/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T545377)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Scheduler for WPF - Create a Basic Scheduling Application

This example creates a basic scheduling application with the [SchedulerControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl).

![SimpleScheduler](images/wpfscheduler_getstartedrun129813.png)

## Implementation Details

* To create a [POCO View Model](https://docs.devexpress.com/WPF/17352/mvvm-framework/viewmodels/runtime-generated-poco-viewmodels), use the [DevExpress MVVM Framework](https://docs.devexpress.com/WPF/15112/mvvm-framework). This is a Data Model that supplies data for a scheduling application.

* The View Model uses the **MedicalAppointment** and **Doctor** class instances as collections of the **ObservableCollection** type collections.

* The scheduling application includes the [Ribbon](https://docs.devexpress.com/WPF/120132/controls-and-libraries/scheduler/visual-elements/ribbon).

* To bind to data, use the [DataSource.AppointmentsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DataSource.AppointmentsSource) (for **MedicalAppointment** objects) and [DataSource.ResourcesSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DataSource.ResourcesSource) (for **Doctor** objects) properties.

* To specify [mappings](https://docs.devexpress.com/WPF/119493/controls-and-libraries/scheduler/data-binding/mappings), use the [DataSource.AppointmentMappings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DataSource.AppointmentMappings) and [DataSource.ResourceMappings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DataSource.ResourceMappings) properties.

## Files to Review

* [Doctor.cs](./CS/SimpleSchedulingExample/Doctor.cs) (VB: [Doctor.vb](./VB/SimpleSchedulingExample/Doctor.vb))
* [MainViewModel.cs](./CS/SimpleSchedulingExample/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/SimpleSchedulingExample/MainViewModel.vb))
* [MainWindow.xaml](./CS/SimpleSchedulingExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/SimpleSchedulingExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/SimpleSchedulingExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/SimpleSchedulingExample/MainWindow.xaml.vb))
* [MedicalAppointment.cs](./CS/SimpleSchedulingExample/MedicalAppointment.cs) (VB: [MedicalAppointment.vb](./VB/SimpleSchedulingExample/MedicalAppointment.vb))

## Documentation

* [Create a Data Model](https://docs.devexpress.com/WPF/119796/controls-and-libraries/scheduler/getting-started/create-a-simple-scheduling-application#create-a-data-model)
* [Create a View Model](https://docs.devexpress.com/WPF/119796/controls-and-libraries/scheduler/getting-started/create-a-simple-scheduling-application#create-a-view-model)
* [Create Ribbon](https://docs.devexpress.com/WPF/119796/controls-and-libraries/scheduler/getting-started/create-a-simple-scheduling-application#create-ribbon)
* [Specify the Scheduler Settings](https://docs.devexpress.com/WPF/119796/controls-and-libraries/scheduler/getting-started/create-a-simple-scheduling-application#specify-the-scheduler-settings)
* [Bind to Data](https://docs.devexpress.com/WPF/119796/controls-and-libraries/scheduler/getting-started/create-a-simple-scheduling-application#bind-to-data)

## More Examples

* [How to: Bind Scheduler to Data using the Entity Framework Code First Approach](https://github.com/DevExpress-Examples/how-to-bind-scheduler-to-data-using-the-entity-framework-code-first-approach-t545436)
* [WPF Scheduler - Customize the Built-In Ribbon Control](https://github.com/DevExpress-Examples/wpf-scheduler-customize-built-in-ribbon-control)
* [How to: Customize Editing and Recurrence Dialogs](https://github.com/DevExpress-Examples/how-to-create-a-scheduling-application-which-uses-custom-editing-and-recurrence-dialog-t545486)
* [WPF Scheduler - Implement a Custom In-Place Appointment Editor](https://github.com/DevExpress-Examples/wpf-scheduler-implement-custom-inplace-appointment-editor)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-create-basic-scheduling-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-create-basic-scheduling-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
