// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "IAnimal.h"
#include "UObject/Object.h"
#include "Dog.generated.h"

/**
 * 
 */
UCLASS()
class MYPROJECT_API UDog : public UObject, public IIAnimal
{
	GENERATED_BODY()

public:
	virtual FString Say() override;

	void Kk();
};
