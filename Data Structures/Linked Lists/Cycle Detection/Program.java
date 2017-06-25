boolean hasCycle(Node head) {
    if (head == null) {
        return false;
    }

    Node current = head;
    Node ahead = head;

    while (current != null && ahead != null) {
        current = current.next;
        ahead = ahead.next.next;

        if (current == null || ahead == null) {
            return false;
        }

        if (current == ahead) {
            return true;
        }
    }

    return false;
}
