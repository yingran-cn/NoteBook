## UE事件多播

1.//在头文件声明一个委托类型
DECLARE_DELEGATE_OneParam(MouseClickDelegate, FString);

2.定义一个刚才声明的变量：

MouseClickDelegate OnMouseClickDelegate;

3.触发事件

OnMouseClickDelegate.ExecuteIfBound(name);

别的地方监听：
UActorComponent* d = GlobalAnimatComponentActor->GetComponentByClass(UGlobalAnimatComponent::StaticClass());

Cast<UGlobalAnimatComponent>(d)->OnMouseClickDelegate.BindUObject(this, &UClickChangeName::ShowClick);
