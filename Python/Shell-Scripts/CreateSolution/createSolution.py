# This is a sample Python script.
import string
import sys
import os

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.


nameOfSolution: string
pathToSolution: string

if __name__ == '__main__':

    nameOfSolution = sys.argv[1]
    pathToSolution = sys.argv[2]

    os.mkdir(nameOfSolution)

    #README
    readmeFile = open(f"{nameOfSolution}/README.md", "w")
    readmeFile.write(f"# {nameOfSolution}\n")
    readmeFile.write(f"## Reference\n")
    readmeFile.write(f"{pathToSolution}\n")
    readmeFile.write("\n")
    readmeFile.write(f"## Description\n")


    #Test File
    testFile = open(f"{nameOfSolution}/test_{nameOfSolution}.py", "w")
    testFile.write("import unittest\n")
    testFile.write("\n")
    testFile.write("if __name__ == '__main__':\n")
    testFile.write("    pass\n")
    testFile.write("\n")
    testFile.write("\n")
    testFile.write("class Solution(object):\n")
    testFile.write("    def main(self, input) -> None:\n")
    testFile.write("        pass\n")
    testFile.write("\n")
    testFile.write("\n")
    testFile.write("class TestSolution(unittest.TestCase):\n")
    testFile.write("\n")
    testFile.write("    def test_Fact1(self):\n")
    testFile.write("        solution = Solution()\n")
    testFile.write("        self.assertEqual(1, 2)\n")

    #Enter and Open
    os.chdir(nameOfSolution)
    os.system("powershell.exe sjp .")
