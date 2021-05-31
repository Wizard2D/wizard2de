#pragma once
#include "pch.h"
#define ICAPI extern "C" __declspec(dllexport)
typedef void (*CallbackFunction)(char*);

ICAPI void test();

//EVENT HANDLING:

ICAPI int NewEvent(const char* name);
ICAPI void HookFunctionToEvent(int EventID, void* functionPtr);
ICAPI bool killEvent(int EventID);
ICAPI void SendEvent(int EventID, const char* cause);

