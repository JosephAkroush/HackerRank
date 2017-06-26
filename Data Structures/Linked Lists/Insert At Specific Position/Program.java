Node InsertNth(Node head, int data, int position) {
    if (position == 0) {
        Node node = new Node();
        node.data = data;
        node.next = head;

        return node;
    } else {
        Node node = head;

        while (--position > 0) {
            node = node.next;
        }

        Node temp = node.next;
        node.next = new Node();
        node.next.data = data;
        node.next.next = temp;

        return head;
    }
}
