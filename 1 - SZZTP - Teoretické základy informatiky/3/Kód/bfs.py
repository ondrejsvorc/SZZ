from collections import deque

class Node:
    def __init__(self, value, children=None):
        self.value = value
        self.children = children or []

def bfs(root: Node, index: int) -> bool:
    queue = deque([root])
    while queue:
        node = queue.popleft()
        if node.value == target:
            return True
        queue.extend(node.children)
    return False

tree = Node(50, [Node(25, [Node(10), Node(30)]), Node(75, [Node(60), Node(90)])])

print(bfs(tree, 10)) # True
print(bfs(tree, 100)) # False