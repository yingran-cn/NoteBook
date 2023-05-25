// Fill out your copyright notice in the Description page of Project Settings.


#include "MyActorComponent.h"

// Sets default values for this component's properties
UMyActorComponent::UMyActorComponent()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;

	dog = NewObject<UDog>();
	mini = NewObject<UMimi>();
	// ...
}


// Called when the game starts
void UMyActorComponent::BeginPlay()
{
	Super::BeginPlay();
	Animals.Add(dog);
	Animals.Add(mini);

	for (IIAnimal* Animal : Animals)
	{
		Animal->Say();
	}
	//dog->Say();
	/*Animal = dog;
	Animal->Say();
	Animal = mini;
	Animal->Say();*/
	// ...
	//UE_LOG(LogTemp, Warning, TEXT(" ww! "))

	//printf("ddsdf %b", d);
}


// Called every frame
void UMyActorComponent::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	// ...
}

