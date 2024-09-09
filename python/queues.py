from collections import deque

class Queue:
    def __init__(self):
        self._elements = deque()
    
    def enqueue(self, element):
        self._elements.append(element)

    def dequeue(self):
        self._elements.popleft()