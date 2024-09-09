from queue import Queue

fifo = Queue()
fifo.put("1st")
fifo.put("2nd")
fifo.put("3rd")

print(fifo.get())  # Saída: 1st
print(fifo.get())  # Saída: 2nd
print(fifo.get())  # Saída: 3rd

