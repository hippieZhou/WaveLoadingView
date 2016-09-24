# WaveLoadingView For WPF


## Images
| Circle | column |
|--------|--------|
|<img src="https://github.com/hippieZhou/ZQ.WaveLoadingView/blob/master/WPF/Screenshots/Cirlce.gif" alt="sample" title="sample" width="631" height="419"/> | <img src="https://github.com/hippieZhou/ZQ.WaveLoadingView/blob/master/WPF/Screenshots/Square.gif" alt="sample" title="sample" width="631" height="419"/> |




## Sample
```XAML
<!--导入命名空间-->
xmlns:local="clr-namespace:WaveLoadingViewDemo"

<!--使用示例-->
<local:WaveLoadingView ShapeType="Cirlce"
                       BorderBrush="#0FBD09"
					   BorderThickness="2"
					   Title="Hello World"
					   TitleColor="#0FBD09"
					   TitleAlignment="Center"
					   TitleVisibility="Visible"
					   Progress="50"
					   WaveColor="#00E4C5"/>

```


## Customization
| name | description       |
|--------|-----------------|
| ShapeType       | the conrtol's Shape Type              |
| BorderBrush     | the control's BorderBrush(Color)      |
| BorderThickness | the control's BorderThicknes(Width)   |
| Title           | the control's Title content           |
| TitleColor      | the control's Title foreground        |
| TitleAlignment  | the control's Title Alignment         |
| TitleVisibility | the control's Title Visibility        |
| Progress        | the control's current procent(max value is 99,min value is 0) |
| WaveColor       | the control's wave clor      |

**All attributes have their respective getters and setters to change them at runtime.**


## Change Change Log
1. ** Create first version for WPF ** [September 24, 2016 9:41 PM]


## Links
1. [WPF实现三星手机充电界面 ](http://www.cnblogs.com/tsliwei/p/5770546.html)
2. [ Windows Phone开发（32）：路径之PathGeometry ](http://blog.csdn.net/tcjiaan/article/details/7469512)
3. [PolyLineSegment 类](https://msdn.microsoft.com/zh-cn/library/system.windows.media.polylinesegment.aspx)


## License

    Copyright 2016 Qi Tang

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.

