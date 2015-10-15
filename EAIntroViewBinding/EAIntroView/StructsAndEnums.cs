using System;
using ObjCRuntime;

namespace EAIntroView
{
	public enum EAIntroViewTags : uint
	{
		TitleLabelTag = 1,
		DescLabelTag,
		TitleImageViewTag
	}

	[Native]
	public enum EAViewAlignment : nuint
	{
		Left,
		Center,
		Right
	}
}
