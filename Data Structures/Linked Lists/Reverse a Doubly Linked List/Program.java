Node Reverse(Node head) {
    if (head == null) {
        return null;
    }

    Node current = head;
    Node previous = null;
    Node next = null;

    while (current != null) {
        next = current.next;
        current.prev = next;
        current.next = previous;
        previous = current;
        current = next;
    }

    return previous;
}
