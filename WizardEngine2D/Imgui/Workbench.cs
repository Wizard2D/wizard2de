using System;
using System.Collections.Generic;
using System.Text;
using ImGuiNET;

namespace WizardEngine2D.Imgui
{
    class Workbench
    {
        public List<string> ConslOUT = new List<string> { "HELLO", "HELLO" };
        public string ConsoleInput = "";
        public void HandleConsoleButton()
        {

        }

        public void DrawConsole()
        {
            ImGuiNET.ImGui.Begin("Console");
            foreach(string ilsm in ConslOUT)
                ImGuiNET.ImGui.TextColored(new System.Numerics.Vector4(0.25f, 0.75f, 0.1f, 1), ilsm);
            ImGuiNET.ImGui.InputTextMultiline("Enter Command: ", ref ConsoleInput, (uint)Math.Pow(2, 16), new System.Numerics.Vector2(120.0f, 35.0f));
            if (ImGuiNET.ImGui.Button("Send"))
            {
                HandleConsoleButton();
            }
            ImGuiNET.ImGui.End();
        }
        public void DrawTopbar()
        {
            ImGui.Begin("Menu");
            ImGui.SetWindowSize(new System.Numerics.Vector2(795, 115));
            ImGui.Text("Objects");
            ImGui.Button("Rect");
            ImGui.Button("Circle");
            ImGui.Button("Triangle");
            ImGui.End();
        }
        public void DrawExplorer()
        {
            ImGui.Begin("Explorer");
            ImGui.TreePush("Explorer");
            if (ImGui.TreeNodeEx("Scene", ImGuiTreeNodeFlags.Framed))
                if (ImGui.TreeNodeEx("Rectangle"))
                    ImGui.TreePop();
            //ImGui.TreeNodeEx("Triangle");
            ImGui.TreePop();
            
            ImGui.TreePop();
            ImGui.End();
        }
        public void DrawProperties()
        {
            int cItem = 0;
            ImGui.Begin("Properties");
            ImGui.ListBox("", ref cItem, new string[] { "Property1", "Property2", "Property3" }, 3);
            ImGui.End();
        }
    }
}
