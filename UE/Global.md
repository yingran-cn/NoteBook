## 全局

只要是继承于ACharacter或APawn类的，都可以把Controller转换成APlayerController来用GetHitResultUnderCursor这个函数，本质上其实是射线检测GetWorld()->LineTraceSingleByChannel，只是做了很多安全判断，比如保证获得玩家屏幕，保证点击的不是UI。
通过Hit传引用进去，传结果出来。Hit.bBlockingHit代表检测到了物体

### APlayerController* OurPlayerController = UGameplayStatics::GetPlayerController(this, 0);

## 射线检测
UE官方的封装GetHitResultUnderCursor用到的代码，最开始的if还判断了点击的是否是UI。
射线检测很简单，只是检测之前要做一步把屏幕坐标转换成3D世界坐标，官方用的是UGameplayStatics::DeprojectScreenToWorld函数

## 鼠标位置
//坐标值是整数
``FIntPoint MousePoint;
GEngine->GameViewport->Viewport->GetMousePos(MousePoint);``
 
//坐标是标准float
``FVector2D CursorPos;
GEngine->GameViewport->GetMousePosition(CursorPos);`` 


