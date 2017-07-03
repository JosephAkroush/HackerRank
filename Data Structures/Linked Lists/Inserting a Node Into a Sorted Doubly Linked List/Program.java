Node SortedInsert(Node head, int data) {
    if (head == null) {
        head = new Node();
        head.data = data;

        return head;
    }

    Node node = head;

    while (node != null) {
        if (node.data < data) {
            if (node.next == null) {
                node.next = new Node();
                node.next.data = data;
                node.next.prev = node;
                break;
            }
        } else if (node.data > data) {
            if (node.prev == null) {
                node.prev = new Node();
                node.prev.data = data;
                node.prev.next = node;
                break;
            } else {
                Node insert = new Node();
                insert.data = data;
                insert.next = node;
                insert.prev = node.prev;
                insert.prev.next = insert;
                insert.next.prev = insert;
                break;
            }
        }

        node = node.next;
    }

    return head;
}
