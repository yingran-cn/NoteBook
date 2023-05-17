## AddOnScreenDebugMessage
GEngine->AddOnScreenDebugMessage(-1, 5, FColor::Red, loc.ToString());
## UE_LOG

TEXT(string)
TEXT宏，作用是将字符串转换成Unicode，切记UE中使用字符串输出要使用该宏

UE_LOG(日志类型，日志等级，字符串)
UE_LOG宏，可在UE editor 中输出调试内容。

FString
FString是UE里的自定义类型，类似C++中的String，用于存放字符串。

FString::Printf
用于将两个不同类型的变量，通过占位符%+类型（例如%s代表字符串，%d代表整型）进行组合，生成FString类型。

FString Name = "V";
 
int32 Age = 23;
 
FString str = FString::Printf(TEXT("Name: %s, Age: %d"), *Name, Age);
目前本人主要用在结合UE_LOG进行字符串格式化输出

UE_LOG(LogTemp, Warning, TEXT("Your String: " %s), *str);
FString::Format
用法类似Python中的{}语法（但不完全相同，UE中{}内，填入的是索引）, 使用{}占位。

需要用到TArray（UE中的自定义类，类似数组），FStringFormatArg（UE中的自定义类，用于FSrting::Format）。

FString Name = "V";
 
int32 Age = 23;
 
TArray<FStringFormatArg> args;
 
args.Add(FStringFormatArg(Name));
 
args.Add(FStringFormatArg(Age));
 
FString Str = FString::Format(TEXT("Name: {0}, Age: {1}")，args);
 
UE_LOG(LogTemp, Warning, TEXT("Your String: &s"), *Str);
用法目前本人主要用到同Printf一样 

注意事项
FString 类型的变量，在UE_LOG中使用时，需要解引用符 * 。
 
 ![image](https://github.com/yingran-cn/NoteBook/assets/26194916/b3c6dd06-378f-4517-ae1d-2759463b638d)

 
https://docs.unrealengine.com/5.2/en-US/string-handling-in-unreal-engine/
 
 https://blog.csdn.net/m0_51819222/article/details/122516259?ops_request_misc=&request_id=&biz_id=102&utm_term=ue%20FText&utm_medium=distribute.pc_search_result.none-task-blog-2~all~sobaiduweb~default-3-122516259.142^v87^insert_down28v1,239^v2^insert_chatgpt&spm=1018.2226.3001.4187
 
