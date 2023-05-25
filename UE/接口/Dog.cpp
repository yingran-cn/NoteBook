// Fill out your copyright notice in the Description page of Project Settings.


#include "Dog.h"

FString UDog::Say()
{
	UE_LOG(LogTemp, Warning, TEXT("Dog ww!"))
	return IIAnimal::Say();
}

void UDog::Kk()
{
	UE_LOG(LogTemp, Warning, TEXT("kk"))

}
