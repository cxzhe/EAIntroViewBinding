//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DVoidBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDVoidBlock {
			static internal readonly DVoidBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DVoidBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::EAIntroViews.VoidBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDVoidBlock */
		
		internal class NIDVoidBlock {
			IntPtr blockPtr;
			DVoidBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDVoidBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DVoidBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDVoidBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::EAIntroViews.VoidBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::EAIntroViews.VoidBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDVoidBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDVoidBlock */
	}
}
