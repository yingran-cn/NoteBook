// Fill out your copyright notice in the Description page of Project Settings.


#include "Mimi.h"

FString UMimi::Say()
{
	UE_LOG(LogTemp, Warning, TEXT("Mimi  !"))

	return IIAnimal::Say();
}
