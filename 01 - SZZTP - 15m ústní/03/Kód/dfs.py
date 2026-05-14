from collections import deque

class Node:
    def __init__(self, value, children=None):
        self.value = value
        self.children = children or []

def dfs(root: Node, target: int) -> bool:
    stack = deque([root])
    while stack:
        node = stack.pop()
        if node.value == target:
            return True
        else:
            for child in reversed(node.children):
                stack.append(child)
    return False

tree = Node(50, [Node(25, [Node(10), Node(30)]), Node(75, [Node(60), Node(90)])])

print(dfs(tree, 10))  # True
print(dfs(tree, 100)) # False