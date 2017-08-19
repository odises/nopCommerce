using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Nop.Web.Extensions
{
    public static class PersianUtils
    {
        public static void InitializePersianCalendar()
        {
            var cultureInfo = new CultureInfo("fa-IR");

            var dtfi = cultureInfo.DateTimeFormat;
            dtfi.AbbreviatedDayNames = new[] { "ي", "د", "س", "چ", "پ", "ج", "ش" };
            dtfi.DayNames = new string[] { "يكشنبه", "دوشنبه", "سه شنبه", "چهار شنبه", "پنجشنبه", "جمعه", "شنبه" };
            var monthNames = new string[] { "فروردين", "ارديبهشت", "خرداد", "تير", "مرداد", "شهريور", "مهر", "آبان", "آذر", "دي", "بهمن", "اسفند", "" };
            dtfi.AbbreviatedMonthNames = dtfi.MonthNames = dtfi.MonthGenitiveNames = dtfi.AbbreviatedMonthGenitiveNames = monthNames;
            dtfi.AMDesignator = "ق.ظ";
            dtfi.PMDesignator = "ب.ظ";
            dtfi.ShortDatePattern = "yy/MM/dd";
            dtfi.FirstDayOfWeek = DayOfWeek.Saturday;

            Calendar cal = new PersianCalendar();

            var memberInfo = dtfi.GetType().GetField("calendar", BindingFlags.NonPublic | BindingFlags.Instance);
            memberInfo?.SetValue(dtfi, cal);

            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        /// <summary>
        /// Convert Arabic characters to Persian
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSafePersian(this string input)
        {
            return input?.Replace("ي", "ی")?.Replace("ك", "ک");
        }

        public static void InitializeEnglishCalendar()
        {
            var cultureInfo = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}