def binary_search(sorted_array: list[int], target: int) -> int:
    left_index = 0
    right_index = len(sorted_array) - 1

    while left_index <= right_index:
        middle_index = (left_index + right_index) // 2
        middle_value = sorted_array[middle_index]

        if middle_value == target:
            return middle_index
        elif middle_value > target:
            right_index = middle_index - 1
        elif middle_value < target:
            left_index = middle_index + 1

    return -1

target_index = binary_search(sorted_array=[1, 2, 3, 4, 5], target=4)
print(target_index) # 3