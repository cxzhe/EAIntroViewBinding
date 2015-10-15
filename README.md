EAIntroViewBinding
===

####EAIntroView binding for Xamarin.iOS

##Develop Environment
* Objective Sharpie 3.0
* Xcode 7.0.1
* OS X OS X 10.10.5 
* SDK IPhoneos 9.0

##Command Line
```bash
cd ~/EAIntroView
xcodebuild -sdk iphonesimulator -configuration Release
xcodebuild -sdk iphoneos -arch armv7 -configuration Release
lipo -create build/Release-iphoneos/libEAIntroView.a build/Release-iphonesimulator/libEAIntroView.a -output EAIntroViewSDK.a

cd ~/EAIntroView/EAIntroViewBinding
sharpie bind -output EAIntroView -namespace EAIntroView -sdk iphoneos9.0 ~/EAIntroView/EAIntroView/EAIntroView.h
```

##Binding by cxzhe [Weibo](http://weibo.com/deepbass)

##Github page of EAIntroView is <br> https://github.com/magerate/EAIntroView
