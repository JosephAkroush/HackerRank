int GetNode(Node head, int n) {
    Node current = head;
    Node next = null;
    Node previous = null;

    // Reverse the linked list
    while (current != null) {
        next = current.next;
        current.next = previous;
        previous = current;
        current = next;
    }

    // Crawl the linked list while decrementing position
    while (--n >= 0) {
        previous = previous.next;
    }

    return previous.data;
}
