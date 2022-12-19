namespace LiturgyScheduler;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}


/* Rules:
 *  1+ MC per Mass
 *  No more than 2 per Mass*
 *  Try not to schedule two weeks in a row**
 * 
 *  * Except for Frassati Masses
 *  ** Except for MC's that want to be scheduled at a greater frequency (e.x. Pete Gann)
 * 
 * Base case:
 *	Weekend Masses: Sat. 4pm; Sun. 6:30am, 9:00am, 11:00am, 5:30pm
 * 
 * Special cases:
 *	Holy Days of Obligation (and the Triduum): Special Mass times and possibly override a set of weekend Masses (e.x. Christmas has no 11:00am)
 *	Frassati Masses: 4-6 MC's to be scheduled.
 * 
 */

/* Other thoughts:
 * Might make most sense to simply create a Mass type with a function that can add/remove slots for a given Mass - at least in the short-term.
 * 
 * Might look into hosting a local database for testing purposes.
 * Username/Password authentication? Would be nice if giving to other ministry schedulers
 * 
 */