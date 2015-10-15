using System;

using ObjCRuntime;

namespace EAIntroViews
{
	public enum EAIntroViewTags : uint
	{
		TitleLabelTag = 1,
		DescLabelTag,
		TitleImageViewTag
	}

	[Native]
	public enum EAViewAlignment : long
	{
		Left,
		Center,
		Right
	}
}
