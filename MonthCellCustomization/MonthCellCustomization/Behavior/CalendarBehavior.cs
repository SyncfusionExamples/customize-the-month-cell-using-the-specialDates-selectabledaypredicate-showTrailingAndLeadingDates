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
            CalendarTextStyle textStyle = new CalendarTextStyle()
            {
                TextColor = Colors.White,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold
            };
            
            this.calendar.MonthView.SpecialDates = new List<DateTime>
            {
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(4),
                DateTime.Now.AddDays(6),
                DateTime.Now.AddDays(-3),
                DateTime.Now.AddDays(-5),
                DateTime.Now.AddDays(-7),
            };

            this.calendar.MonthView.SpecialDatesBackground = Color.FromArgb("#FF7D7D");
            this.calendar.MonthView.SpecialDatesTextStyle = textStyle;
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
            this.calendar.MonthView.TrailingLeadingDatesTextStyle = textStyle;
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
            this.calendar = null;
        }
    }
}
