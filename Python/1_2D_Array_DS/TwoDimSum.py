
class TwoDimSum:

    def hourglassSum(arr):

        sums = TwoDimSum.getArrayOfSums(arr)
        output = max(sums)
        return output

    def getSubArray(lookupArray, centerIndex):
        outputArray = []

        outputArray.append(lookupArray[centerIndex - 7])
        outputArray.append(lookupArray[centerIndex - 6])
        outputArray.append(lookupArray[centerIndex - 5])

        #outputArray.append(lookupArray[centerIndex - 1])
        outputArray.append(lookupArray[centerIndex])
        #outputArray.append(lookupArray[centerIndex + 1])

        outputArray.append(lookupArray[centerIndex + 5])
        outputArray.append(lookupArray[centerIndex + 6])
        outputArray.append(lookupArray[centerIndex + 7])

        return outputArray

    def getArrayOfSums(arrayOfInts):
        outputArray = []

        centerIndexes = [8, 9, 10, 11,
                         14, 15, 16, 17,
                         20, 21, 22, 23,
                         26, 27, 28, 29]

        lookupArray = TwoDimSum.getLookup(arrayOfInts)

        for index in centerIndexes:
            subArray = TwoDimSum.getSubArray(lookupArray, index)
            outputArray.append(sum(subArray))

        return outputArray

    def getLookup(input):
        index = 1
        lookup = {}

        for row in range(6):
            for column in range(6):
                value = input[row][column]

                lookup[index] = value
                index += 1

        return lookup

    def getConvertedInput(rawInput):
        convertedInput = []

        for line in rawInput.split('\n'):
            convertedLine = list(map(int, line.rstrip().split()))
            convertedInput.append(convertedLine)

        return convertedInput