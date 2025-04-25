using Syncfusion.Maui.Calendar;

namespace MonthCellCustomization
{
    public class CalendarBehavior : Behavior<SfCalendar>
    {
        private SfCalendar calendar;

        protected override void OnAttachedTo(SfCalendar bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable;
            this.calendar.MonthView.SpecialDayPredicate = (date) =>
            {
                if (date.Date == DateTime.Now.AddDays(2).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Dot;
                    iconDetails.Fill = Colors.Red;
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(4).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Triangle;
                    iconDetails.Fill = Colors.Blue;
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(-3).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Square;
                    iconDetails.Fill = Colors.Green;
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(-5).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Heart;
                    iconDetails.Fill = Colors.Red;
                    return iconDetails;
                }
                else if (date.Date == DateTime.Now.AddDays(-7).Date)
                {
                    CalendarIconDetails iconDetails = new CalendarIconDetails();
                    iconDetails.Icon = CalendarIcon.Diamond;
                    iconDetails.Fill = Colors.Blue;
                    return iconDetails;
                }

                return null;
            };

            this.calendar.MonthView.SpecialDatesBackground = Color.FromArgb("#FF7D7D");
            this.calendar.MonthView.SpecialDatesTextStyle = new CalendarTextStyle()
            {
                TextColor = Colors.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            this.calendar.SelectableDayPredicate = (date) =>
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    return false;
                }

                return true;
            };

            this.calendar.MonthView.DisabledDatesBackground= Color.FromArgb("#DBDBDB");
            this.calendar.MonthView.DisabledDatesTextStyle = new CalendarTextStyle()
            {
                TextColor = Colors.Gray,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };

            this.calendar.ShowTrailingAndLeadingDates = false;
            this.calendar.MonthView.TrailingLeadingDatesBackground = Color.FromArgb("#AEAEFF");
            this.calendar.MonthView.TrailingLeadingDatesTextStyle = new CalendarTextStyle()
            {
                TextColor = Colors.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
            this.calendar = null;
        }
    }
}
