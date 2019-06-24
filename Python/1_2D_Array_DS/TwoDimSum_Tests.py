#Reference:
# https://docs.python.org/3/library/unittest.html
# ddt.readthedocs.io/en/latest/example.html


import unittest
from ddt import ddt, data, unpack
from TwoDimSum import TwoDimSum

class twoDimSum_Tests(unittest.TestCase):

    def test_hourglasssum_ReturnsCorrectsum_1(self):
        rawInput = """1 1 1 0 0 0
                       0 1 0 0 0 0
                       1 1 1 0 0 0
                       0 0 2 4 4 0
                       0 0 0 2 0 0
                       0 0 1 2 4 0"""

        expectedOutput = 19

        input = TwoDimSum.getConvertedInput(rawInput)

        output = TwoDimSum.hourglassSum(input)

        self.assertEqual(expectedOutput, output)

    def test_getSubArray_ReturnsCorrectSubArray(self):
        rawInput = """1 1 1 0 0 0
                       0 1 0 0 0 0
                       1 1 1 0 0 0
                       0 0 2 4 4 0
                       0 0 0 2 0 0
                       0 0 1 2 4 0"""

        expectedOuput = [1, 1, 1,  1, 1, 1, 1]

        testInput = TwoDimSum.getConvertedInput(rawInput)
        lookup = TwoDimSum.getLookup(testInput)
        centerIndex = 8

        output = TwoDimSum.getSubArray(lookup, centerIndex)

        self.assertEqual(expectedOuput, output)

    def test_getArrayOfSums(self):
        expectedOutput = [-63, -34, -9, 12, -10, 0, 28, 23, -27, -11, -2, 10, 9, 17, 25, 18]
        rawInput = """-9 -9 -9  1 1 1 
                               0 -9  0  4 3 2
                              -9 -9 -9  1 2 3
                               0  0  8  6 6 0
                               0  0  0 -2 0 0
                               0  0  1  2 4 0"""

        testInput = TwoDimSum.getConvertedInput(rawInput)
        arrayOfSums = TwoDimSum.getArrayOfSums(testInput)

        self.assertEqual(expectedOutput, arrayOfSums)

    @unittest.skip("A one time thing to verify it looks alright")
    def test_getLookup_LooksLegit(self):
        rawInput = """1 1 1 0 0 0
                               0 1 0 0 0 0
                               1 1 1 0 0 0
                               0 0 2 4 4 0
                               0 0 0 2 0 0
                               0 0 1 2 4 0"""

        input = TwoDimSum.getConvertedInput(rawInput)

        output = TwoDimSum.getLookup(input)
        print(output)

if __name__ == '__main__':
    unittest.main()

# class testHelpers:

    # def getConvertedInput():
    #     convertedInput = []
    #     rawInput = """1 1 1 0 0 0
    #                        0 1 0 0 0 0
    #                        1 1 1 0 0 0
    #                        0 0 2 4 4 0
    #                        0 0 0 2 0 0
    #                        0 0 1 2 4 0"""
    #
    #     for line in rawInput.split('\n'):
    #         convertedLine = list(map(int, line.rstrip().split()))
    #         convertedInput.append(convertedLine)
    #
    #     return convertedInput

    # def getConvertedInput_SumTest():
    #     convertedInput = []
    #     rawInput = """-9 -9 -9  1 1 1
    #                    0 -9  0  4 3 2
    #                   -9 -9 -9  1 2 3
    #                    0  0  8  6 6 0
    #                    0  0  0 -2 0 0
    #                    0  0  1  2 4 0"""
    #
    #     for line in rawInput.split('\n'):
    #         convertedLine = list(map(int, line.rstrip().split()))
    #         convertedInput.append(convertedLine)
    #
    #     return convertedInput

