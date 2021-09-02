from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for outerIndex, outer in enumerate(nums):
            for innerIndex, inner in enumerate(nums,):
                if innerIndex <= outerIndex:
                    continue
                if (outer + inner) == target:
                    return [outerIndex, innerIndex]