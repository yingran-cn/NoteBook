// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "IAnimal.h"
#include "UObject/Object.h"
#include "Mimi.generated.h"

/**
 * 
 */
UCLASS()
class MYPROJECT_API UMimi : public UObject, public IIAnimal
{
	GENERATED_BODY()

public:
	virtual FString Say() override;
};
