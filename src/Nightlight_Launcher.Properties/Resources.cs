using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Nightlight_Launcher.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Nightlight_Launcher.Properties.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap discordimg
	{
		get
		{
			object obj = ResourceManager.GetObject("discordimg", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap githubimg
	{
		get
		{
			object obj = ResourceManager.GetObject("githubimg", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap gta4img
	{
		get
		{
			object obj = ResourceManager.GetObject("gta4img", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap gta5img
	{
		get
		{
			object obj = ResourceManager.GetObject("gta5img", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap rdr2img
	{
		get
		{
			object obj = ResourceManager.GetObject("rdr2img", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
	}
}
