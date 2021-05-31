// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include "Ironclad.h"
void test() {
    std::cout << "From Ironclad";
}
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        std::cout << "Ironclad v1.0 has been loaded.";
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

